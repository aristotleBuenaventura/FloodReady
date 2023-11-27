using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject playerResultCanvas;
    public GameObject playerAccomplishmentsCanvas;

    private void Start()
    {
        // Ensure both canvases are initially in the desired state
        playerResultCanvas.SetActive(true);
        playerAccomplishmentsCanvas.SetActive(false);
    }

    private void Update()
    {
        // Check for raycast hit when the mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Raycast to check if the button is clicked
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // Toggle canvases
                    ToggleCanvases();
                }
            }
        }
    }

    private void ToggleCanvases()
    {
        // Toggle the state of canvases
        Debug.Log("TOGGLE CANVAS");
        playerResultCanvas.SetActive(!playerResultCanvas.activeSelf);
        playerAccomplishmentsCanvas.SetActive(!playerAccomplishmentsCanvas.activeSelf);
    }
}
