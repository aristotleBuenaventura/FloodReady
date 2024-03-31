using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    void Start()
    {
        // Set the initial text
        textMeshPro.text = "WELL DONE!";
        // Call the function to change text immediately
    }

    public void ChangeToTimeRunOut()
    {
        // Change the text
        textMeshPro.text = "TIME RAN OUT!";

    } 

    public void ChangeToPlayerDead()
    {
        // Change the text
        textMeshPro.text = "YOU'RE DEAD";
    }
}