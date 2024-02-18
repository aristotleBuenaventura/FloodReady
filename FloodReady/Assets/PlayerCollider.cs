using System.Collections;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public GameObject playerTag;
    public GameObject objectsToDisable;


    void Start()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playerTag)
        {
            objectsToDisable.SetActive(false);
        }
    }
}
