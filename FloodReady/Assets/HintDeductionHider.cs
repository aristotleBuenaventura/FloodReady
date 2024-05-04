using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDeductionHider : MonoBehaviour
{
   public GameObject Hider;

    void Start()
    {
        Hider.SetActive(false);
    }

   
}
