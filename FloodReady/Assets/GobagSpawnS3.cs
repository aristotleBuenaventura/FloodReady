using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobagSpawnS3 : MonoBehaviour
{
    public GameObject goBag;
    public GameObject circlePoint;
    // Start is called before the first frame update
    void Start()
    {
        goBag.SetActive(false);
        circlePoint.SetActive(false);
    }


}
