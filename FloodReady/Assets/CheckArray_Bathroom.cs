using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckArray_Bathroom : MonoBehaviour
{
    public Bathroom_MiniGame check;
    public int arraynum;
    // Start is called before the first frame update
    void Start()
    {
        check.checklist[arraynum] = true;
    }
}
