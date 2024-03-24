using UnityEngine;

public class SecondFloorDetector : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector
    public GameObject CubeDetector;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            CubeDetector.SetActive(true);
        }

    }
}
