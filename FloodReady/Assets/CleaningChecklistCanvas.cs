using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningChecklistCanvas : MonoBehaviour
{
    public GameObject LivingRoom;
    // Start is called before the first frame update
    void Start()
    {
        LivingRoom.SetActive(false);
    }

    public void ShowLivingRoomCanvas()
    {
        LivingRoom.SetActive(true);
    }
}
