using System.Collections;
using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
    public float buttonCooldown = 2.0f; // Adjust the cooldown time as needed
    private bool isTouched = false;
    private bool canToggleLights = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cube.009") && canToggleLights)
        {
            GameObject[] pointLights = GameObject.FindGameObjectsWithTag("pointlight");

            foreach (GameObject pointLight in pointLights)
            {
                Light lightComponent = pointLight.GetComponent<Light>();
                if (lightComponent != null)
                {
                    lightComponent.enabled = !isTouched;
                }
            }

            isTouched = !isTouched;
            canToggleLights = false;
            StartCoroutine(ButtonCooldown());
        }
    }

    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(buttonCooldown);
        canToggleLights = true;
    }
}
