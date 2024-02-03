using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    public Transform CopyTarget;

    private void FixedUpdate()
    {
        CopyTarget.position = transform.position;
    }
}
