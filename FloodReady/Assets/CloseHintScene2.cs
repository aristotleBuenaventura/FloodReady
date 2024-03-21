using UnityEngine;

public class CloseHintScene2 : MonoBehaviour
{
    public GameObject objectToShow;
    public ShowHintCanvasScene2 showHintCanvas;
    public GameObject[] hintIcons;

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

            foreach (GameObject obj in hintIcons)
            {
                if (obj != null) // Check if the GameObject reference is not null
                {
                    obj.SetActive(false);
                }
            }
        }
    }
}
