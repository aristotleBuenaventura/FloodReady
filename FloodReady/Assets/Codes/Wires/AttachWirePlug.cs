using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachWirePlug : MonoBehaviour
{
    public Vector3 pluggedPosition;
    public Quaternion pluggedRotation;
    public Vector3 initialPosition;
    public Quaternion initialRotation;
    GameObject plug;
    AudioSource sound;
    public bool isPlugged;

    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPlugged = false;
        Debug.Log("Initial Position: " + initialPosition);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!isPlugged && (other.gameObject.tag == "PowerSocket" || other.gameObject.tag == "TV Outlet"))
        {
            isPlugged = true;

            // Disable the Grabbable component
            OVRGrabbable grabbable = other.gameObject.GetComponent<OVRGrabbable>();
            if (grabbable != null)
            {
                grabbable.enabled = false;
            }

            initialPosition = other.transform.position;
            initialRotation = other.transform.rotation;

            // Move the object into the plugged position
            StartCoroutine(MoveOverSpeed(other.gameObject, pluggedPosition, 1f));

            other.transform.rotation = pluggedRotation;
            plug = other.gameObject;
            sound.Play();

            Debug.Log("Plugged Rotation: " + pluggedRotation.ToString());

        }
    }

    public void detach()
    {
        if (plug != null)
        {
            StartCoroutine(MoveBackOverSpeed(plug, initialPosition, 1f));
        }
    }

    public IEnumerator MoveOverSpeed(GameObject objectToMove, Vector3 end, float speed)
    {
        while (Vector3.Distance(objectToMove.transform.position, end) > 0.01f)
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, end, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
    }

    public IEnumerator MoveBackOverSpeed(GameObject objectToMove, Vector3 end, float speed)
    {
        while (Vector3.Distance(objectToMove.transform.position, end) > 0.01f)
        {
            objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, end, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(1);

        OVRGrabbable grabbable = objectToMove.GetComponent<OVRGrabbable>();
        if (grabbable != null)
        {
            grabbable.enabled = true;
        }

        objectToMove.transform.rotation = initialRotation;
        plug = null;
        sound.Play();
        isPlugged = false;
    }
}
