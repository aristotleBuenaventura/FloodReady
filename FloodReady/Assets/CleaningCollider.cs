using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningCollider : MonoBehaviour
{

    public GameObject Kitchen;
    public GameObject Bathroom;
    public GameObject Stairs;
    public GameObject Bedroom;
    // Start is called before the first frame update
    void Start()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
    }

    public void LivingRoomColliders()
    {
        Kitchen.SetActive(true);
        Bathroom.SetActive(true);
        Stairs.SetActive(true);
        Bedroom.SetActive(true);
    }

    public void KitchenColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(true);
        Stairs.SetActive(true);
        Bedroom.SetActive(true);
    }

    public void SecondFloorColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(true);
        Stairs.SetActive(false);
        Bedroom.SetActive(true);
    }

    public void BedRoomColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(true);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
    }

    public void BathroomColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
    }
}
