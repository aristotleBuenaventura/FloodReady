using UnityEngine;

public class RotateVRObject : MonoBehaviour
{
    // Singleton instance
    public static RotateVRObject instance;

    public float rotationSpeed = 1000.0f;
    public bool shouldRotate = true;

    void Awake()
    {
        // Ensure only one instance of RotateVRObject exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (shouldRotate)
        {
            // Rotate around negative Vector3.right to reverse rotation
            transform.Rotate(-Vector3.right, rotationSpeed * Time.deltaTime);
        }
    }

    // Static method to change shouldRotate
    public static void SetShouldRotate(bool value)
    {
        instance.shouldRotate = value;
    }
}
