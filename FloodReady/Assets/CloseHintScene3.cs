using UnityEngine;

public class CloseHintScene3 : MonoBehaviour
{
    public GameObject objectToShow; // disabling the X hint icon  at start of the game
    public ShowHintCanvasScene3 showHintCanvas;
    public GameObject[] hintIcons; // array of hint icons to disable INPUT HERE THE ICONS THAT YOU WILL DISABLE

    private void Start()
    {
        objectToShow.SetActive(false);   // disabling the X hint icon at start of the game
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            objectToShow.SetActive(false); // disabling the X hint icon 
            showHintCanvas.HideAllCanvas(); // disabling the main canvas 

            foreach (GameObject obj in hintIcons)
            {
                if (obj != null) // Check if the GameObject reference is not null
                {
                    obj.SetActive(false); // disabling all the hint icons 
                }
            }
        }
    }
}
