using UnityEngine;

public class LivingRoomDetector : MonoBehaviour
{

    public GameObject CubeDetector;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            CubeDetector.SetActive(true);
}

    }

}
