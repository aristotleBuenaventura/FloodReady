using UnityEngine;

public class UnderWaterEffects : MonoBehaviour
{
    [SerializeField] GameObject waterFx;
    private bool isFogActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Post"))
        {
            isFogActive = !isFogActive; // Toggle the fog state
            RenderSettings.fog = isFogActive;
        } 
    }
}
