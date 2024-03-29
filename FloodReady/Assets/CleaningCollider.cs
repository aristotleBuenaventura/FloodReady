using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningCollider : MonoBehaviour
{

    public GameObject Kitchen;
    public GameObject Bathroom;
    public GameObject Stairs;
    public GameObject Bedroom;
    public GameObject WholeStairs;
    // Start is called before the first frame update
    void Start()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
        WholeStairs.SetActive(false);
    }

    public void SecondFloorColliders()
    {
        Kitchen.SetActive(true);
        Bathroom.SetActive(true);
        Stairs.SetActive(true);
        Bedroom.SetActive(true);
        WholeStairs.SetActive(true);
    }

    public void BedRoomColliders()
    {
        Kitchen.SetActive(true);
        Bathroom.SetActive(true);
        Stairs.SetActive(true);
        Bedroom.SetActive(false);
        WholeStairs.SetActive(true);
    }

    public void LivingRoomColliders()
    {
        Kitchen.SetActive(true);
        Bathroom.SetActive(true);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
        WholeStairs.SetActive(false);
    }

    public void KitchenColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(true);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
        WholeStairs.SetActive(false);
    }

    public void BathroomColliders()
    {
        Kitchen.SetActive(false);
        Bathroom.SetActive(false);
        Stairs.SetActive(false);
        Bedroom.SetActive(false);
        WholeStairs.SetActive(false);
    }
}
