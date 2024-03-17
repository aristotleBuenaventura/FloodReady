using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Task : MonoBehaviour
{
    public GameObject RetrieveGoBagCanvas;

    void Start()
    {
        RetrieveGoBagCanvas.SetActive(false);

    }

    public void RetrieveGobag()
    {
        RetrieveGoBagCanvas.SetActive(true);

    }

}
