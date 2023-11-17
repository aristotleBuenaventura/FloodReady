using UnityEngine;

public class RotateVRObject : MonoBehaviour
{
    public float rotationSpeed = 1000.0f;

    void Update()
    {
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
