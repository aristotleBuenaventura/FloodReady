using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTheWaterNozzleCanvas : MonoBehaviour
{
    public RecoveryCanvasController FindTheWaterNozzle;
    public GameObject nozzle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowCanvasWithDelay(10f));
    }

    IEnumerator ShowCanvasWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        FindTheWaterNozzle.ShowfindnozzleCanvas();
        nozzle.SetActive(true);
    }
}
