using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckArray_Kitchen : MonoBehaviour
{
    public Kitchen_MiniGame check;
    public int arraynum;
    // Start is called before the first frame update
    void Start()
    {
        check.checklist[arraynum] = true;
    }
}
