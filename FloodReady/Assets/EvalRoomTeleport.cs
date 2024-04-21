using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvalRoomTeleport : MonoBehaviour
{
    public S1Evalroom tp;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        tp.TeleportRoom();
        portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
