using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Teleport : MonoBehaviour
{
    public SceneChanger changer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            changer.MoveToEscape_Survive();
        }
    }
}
