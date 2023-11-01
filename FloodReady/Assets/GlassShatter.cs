using UnityEngine;

public class GlassShatter : MonoBehaviour
{
    public float shatterForce = 1000f;
    public GameObject shatteredGlassPrefab; // Prefab of shattered glass
    public string pryBarObjectName = "PryBar"; // Name of the PryBar GameObject

    private bool isShattered = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= shatterForce && !isShattered)
        {
            // Check if the colliding object has the specified name
            if (collision.gameObject.name == pryBarObjectName)
            {
                ShatterGlass();
            }
        }
    }

    void ShatterGlass()
    {
        isShattered = true;

        // Instantiate shattered glass prefab
        Instantiate(shatteredGlassPrefab, transform.position, transform.rotation);

        // Destroy the original glass object (Plane.003)
        Destroy(transform.Find("Plane.003").gameObject);
    }
}
