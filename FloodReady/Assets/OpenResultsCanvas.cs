using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;

    // Reference to the button component
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        // Get the button component on the GameObject
        button = GetComponent<Button>();

        // Attach a method to the button click event
        button.onClick.AddListener(ToggleCanvases);
    }

    // Method to toggle canvases
    void ToggleCanvases()
    {
        // Toggle canvas visibility
        canvas1.gameObject.SetActive(!canvas1.gameObject.activeSelf);
        canvas2.gameObject.SetActive(!canvas2.gameObject.activeSelf);
    }
}
