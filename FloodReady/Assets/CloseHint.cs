using UnityEngine;

public class CloseHint : MonoBehaviour
{
    public GameObject objectToShow;
    public ShowHintCanvas showHintCanvas;

    private void Start()
    {
        objectToShow.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            objectToShow.SetActive(false);
            showHintCanvas.HideAllCanvas();


        }
    }

}
