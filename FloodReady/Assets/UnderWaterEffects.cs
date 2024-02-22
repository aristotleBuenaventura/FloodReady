using UnityEngine;

public class UnderWaterEffects : MonoBehaviour
{
    [SerializeField] GameObject postObject;
    [SerializeField] GameObject waterFx;
    private bool isFogActive = false;

    void Update()
    {
        if (postObject != null)
        {
            float postHeight = postObject.transform.position.y;
            float objectHeight = transform.position.y;
            if (postHeight < objectHeight)
            {
                isFogActive = false;
                RenderSettings.fog = isFogActive;
            }
            else
            {
                isFogActive = true;
                RenderSettings.fog = isFogActive;
            }
        }
        else
        {
            Debug.LogWarning("Post object is not assigned!");
        }
    }
}
