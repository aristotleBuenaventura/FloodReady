using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvacuationChecklist : MonoBehaviour
{
    public GameObject HowToPrepareGoBag;
    public GameObject Scene1Checklist;

    // Start is called before the first frame update
    void Start()
    {
        Scene1Checklist.SetActive(false);
        HowToPrepareGoBag.SetActive(false);

    }

    public void Scene1ChecklistCanvas()
    {
        Scene1Checklist.SetActive(true);
        HowToPrepareGoBag.SetActive(false);
    }

    public void HowToPrepareGoBagCanvas()
    {
        Scene1Checklist.SetActive(false);
        HowToPrepareGoBag.SetActive(true);
    }
}
