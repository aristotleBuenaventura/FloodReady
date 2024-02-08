using UnityEngine;

public class HintDissapearValve : MonoBehaviour
{
    public GameObject handL; // Assign the left hand GameObject to this variable in the Inspector
    public GameObject handR; // Assign the right hand GameObject to this variable in the Inspector

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == handL || other.gameObject == handR)
        {
            // If the gas bottle hint collides with either hand, deactivate it
            gameObject.SetActive(false);
        }
    }
}
