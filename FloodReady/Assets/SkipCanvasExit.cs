using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCanvasExit : MonoBehaviour
{
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    // Start is called before the first frame update

    public void CloseCanvas()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(false);
        Scene3.SetActive(false);
    }
}
