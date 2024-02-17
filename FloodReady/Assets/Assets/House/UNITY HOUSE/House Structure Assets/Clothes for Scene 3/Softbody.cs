using UnityEngine;

public class Softbody : MonoBehaviour
{
    public float stiffness = 1f; // Adjust the stiffness of the softbody
    public float damping = 0.1f; // Adjust the damping of the softbody
    public float mass = 1f; // Adjust the mass of the nodes

    private Vector3[] velocities; // Velocity of each node
    private Vector3[] accelerations; // Acceleration of each node
    private Vector3[] nodePositions; // Current position of each node
    private Vector3[] previousNodePositions; // Previous position of each node

    void Start()
    {
        InitializeSoftbody();
    }

    void Update()
    {
        ApplyForces();
        UpdatePositions();
    }

    void InitializeSoftbody()
    {
        // Initialize arrays
        int numNodes = transform.childCount;
        velocities = new Vector3[numNodes];
        accelerations = new Vector3[numNodes];
        nodePositions = new Vector3[numNodes];
        previousNodePositions = new Vector3[numNodes];

        // Set initial positions
        for (int i = 0; i < numNodes; i++)
        {
            nodePositions[i] = transform.GetChild(i).position;
            previousNodePositions[i] = nodePositions[i];
        }
    }

    void ApplyForces()
    {
        int numNodes = transform.childCount;

        // Apply spring forces between each connected node
        for (int i = 0; i < numNodes; i++)
        {
            Vector3 force = Vector3.zero;

            // Apply forces from neighboring nodes
            for (int j = 0; j < numNodes; j++)
            {
                if (i != j)
                {
                    Vector3 direction = nodePositions[j] - nodePositions[i];
                    float distance = direction.magnitude;
                    Vector3 forceDirection = direction.normalized;

                    // Hooke's Law (spring force)
                    force += forceDirection * stiffness * (distance - Vector3.Distance(previousNodePositions[i], previousNodePositions[j]));
                }
            }

            // Apply damping force
            force -= damping * velocities[i];

            // F = ma
            accelerations[i] = force / mass;
        }
    }

    void UpdatePositions()
    {
        int numNodes = transform.childCount;

        // Update velocities and positions using Verlet integration
        for (int i = 0; i < numNodes; i++)
        {
            Vector3 temp = nodePositions[i];
            nodePositions[i] += (nodePositions[i] - previousNodePositions[i]) + accelerations[i] * Time.deltaTime * Time.deltaTime;
            previousNodePositions[i] = temp;
            velocities[i] = (nodePositions[i] - previousNodePositions[i]) / Time.deltaTime;
        }

        // Update node positions in the Unity scene
        for (int i = 0; i < numNodes; i++)
        {
            transform.GetChild(i).position = nodePositions[i];
        }
    }
}
