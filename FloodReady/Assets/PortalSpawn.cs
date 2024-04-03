using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawn : MonoBehaviour
{
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        portal.SetActive(true);
    }

}
