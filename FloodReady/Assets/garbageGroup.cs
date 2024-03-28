using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garbageGroup : MonoBehaviour
{
    public GameObject trash1;
    public GameObject trash2;
    public GameObject trash3;

    // Start is called before the first frame update
    void Start()
    {
        trash1.SetActive(true); 
        trash2.SetActive(false);
        trash2.SetActive(false);
    }
}
