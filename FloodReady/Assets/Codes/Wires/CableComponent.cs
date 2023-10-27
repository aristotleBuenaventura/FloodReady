using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CableComponent : MonoBehaviour
{
    #region configurations

    [SerializeField] private Transform endPoint;
    [SerializeField] private Material cableMaterial;

    //TV Cable Config
    [SerializeField] private float cableLength = 0.5f;
    [SerializeField] private int totalSegments = 5;
    [SerializeField] private float segmentsPerUnit = 2f;
    private int segments = 0;
    [SerializeField] private float cableWidth = 0.1f;

    //Solver Config
    [SerializeField] private int verletIteration = 1;
    [SerializeField] private int solverIteration = 1;

    private LineRenderer line;
    private CableParticle[] points;

    #endregion

    #region Initial Setup

    void Start()
    {
        InitCableParticles();
        InitLineRenderer();
    }

    void InitCableParticles()
    {
        //Calculate segments to use
            if(totalSegments > 0)
                segments = totalSegments;
            else
                segments = Mathf.CeilToInt (cableLength * segmentsPerUnit);
            Vector3 cableDirection = (endPoint.position - transform.position).normalized;
            float initialSegmentLength = cableLength / segments;
            points = new CableParticle[segments + 1];

            //Foreach points
            for (int pointIdx = 0; pointIdx <= segments; pointIdx++) {
                //Initial position
                Vector3 initialPosition = transform.position + (cableDirection * (initialSegmentLength * pointIdx));
                points[pointIdx] = new CableParticle(initialPosition);
            }

            //Bind start and end particles
            CableParticle start = points[0];
            CableParticle end = points[segments];
            start.Bind(this.transform);
            end.Bind(endPoint.transform);
    }

    void InitLineRenderer()
    {
        line = this.gameObject.AddComponent<LineRenderer>();
        line.startWidth = cableWidth;
        line.endWidth = cableWidth;
        line.positionCount = segments + 1;
        line.material = cableMaterial;
        line.enabled = true;
    }

    #endregion

    #region Render Pass

    void Update()
    {
        RenderCable();
    }

    //Render Cable - update every particle position in the line renderer

    void RenderCable()
    {
        for(int pointIdx = 0; pointIdx < segments + 1; pointIdx++)
        {
            line.SetPosition(pointIdx, points [pointIdx].Position);
        }
    }

    #endregion

    #region Verlet integration and Solver Pass

    void FixedUpdate()
    {
        for (int verletIdx = 0; verletIdx < verletIteration; verletIdx++)

        {
            VerletIntegrate();
            SolveConstraints();
        }
    }

    //Every particle update its position and speed.

    void VerletIntegrate()
    {
        Vector3 gravityDisplacement = Time.fixedDeltaTime * Time.fixedDeltaTime * Physics.gravity;
        foreach (CableParticle particle in points)
        {
            particle.UpdateVerlet(gravityDisplacement);
        }
    }

    //Every constraint is addressed in sequence
    void SolveConstraints(){
        //For each solver iteration..
        for (int iterationIdx = 0; iterationIdx < solverIteration; iterationIdx++)
        {
            SolveDistanceConstraint();
            SolveStiffnessConstraint();
        }
    }

    #endregion

    #region Solver Constraints

    //Distance constraint for each segment / pair of particles
    void SolveDistanceConstraint()
	{
		float segmentLength = cableLength / segments;
		for (int SegIdx = 0; SegIdx < segments; SegIdx++) 
		{
			CableParticle particleA = points[SegIdx];
			CableParticle particleB = points[SegIdx + 1];

			// Solve for this pair of particles
			SolveDistanceConstraint(particleA, particleB, segmentLength);
		}
	}

    //Keeps the cable particles tied together
    void SolveDistanceConstraint(CableParticle particleA, CableParticle particleB, float segmentLength)
	{
		// Find current vector between particles
		Vector3 delta = particleB.Position - particleA.Position;
		// 
		float currentDistance = delta.magnitude;
		float errorFactor = (currentDistance - segmentLength) / currentDistance;
		
		// Only move free particles to satisfy constraints
		if (particleA.IsFree() && particleB.IsFree()) 
		{
			particleA.Position += errorFactor * 0.5f * delta;
			particleB.Position -= errorFactor * 0.5f * delta;
		} 
		else if (particleA.IsFree()) 
		{
			particleA.Position += errorFactor * delta;
		} 
		else if (particleB.IsFree()) 
		{
			particleB.Position -= errorFactor * delta;
		}
	}

    //Stiffness constraint
    void SolveStiffnessConstraint()
	{
		float distance = (points[0].Position - points[segments].Position).magnitude;
		if (distance > cableLength) 
		{
			foreach (CableParticle particle in points) 
			{
				SolveStiffnessConstraint(particle, distance);
			}
		}	
	}

    void SolveStiffnessConstraint(CableParticle cableParticle, float distance)
	{
	

	}


	#endregion
}
