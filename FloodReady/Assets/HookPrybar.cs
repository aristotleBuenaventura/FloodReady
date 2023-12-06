using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPrybar : MonoBehaviour
{
    private Rigidbody rb;
    bool isAttach = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Set it to kinematic initially
        rb.useGravity = false; // Disable gravity initially
    }

    void Update(){
        if(isAttach == false){
            DetachFromHook();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hook"))
        {
            AttachToHook();
            isAttach = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hook"))
        {
            DetachFromHook();
            isAttach = false;
        }
    }

    public void GrabPrybar()
    {
        rb.isKinematic = false; // Disable kinematic to enable physics
        rb.useGravity = true;   // Enable gravity to make it fall
    }

    private void AttachToHook()
    {
        rb.isKinematic = true;  // Set it back to kinematic when attached to the hook
        rb.useGravity = false;  // Disable gravity when attached to the hook
    }

    private void DetachFromHook()
    {
        rb.isKinematic = false; // Disable kinematic when detached from the hook
        rb.useGravity = true;   // Enable gravity when detached from the hook
    }
}
