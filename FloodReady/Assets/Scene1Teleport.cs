using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Teleport : MonoBehaviour
{
    // Expose the desired position and rotation in the Inspector

    public SceneChanger changer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            changer.MoveToEvacuation_Essential();
        }
    }

    
}
