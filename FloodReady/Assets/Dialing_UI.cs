using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dialing_UI : MonoBehaviour
{
    public GameObject dial;
    public GameObject calling;
    public AudioSource ring;

    void Start()
    {
        calling.SetActive(false);

        // Check if the ring AudioSource and its clip are assigned
        if (ring != null && ring.clip != null)
        {
            // Start playing the ring audio source
            ring.Play();
        }
        else
        {
            Debug.LogWarning("Ring AudioSource or AudioClip is not assigned.");
        }

        StartCoroutine(DelayedAction());
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(10f);

        calling.SetActive(true);
        Debug.Log("Ring sound stopped");
        dial.SetActive(false);
    }
}
