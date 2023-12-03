using UnityEngine;

public class LocateMobilePhone : MonoBehaviour
{
    public iconforlocate iconMobilePhone;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the "MobilePhone" tag
        if (other.CompareTag("Hand"))
        {
            // Display a debug log when the mobile phone is located
            Debug.Log("Mobile phone located!");

            // Assuming IconForLocate has methods to handle icon visibility
            iconMobilePhone.SetCheckIconVisible(true);
            iconMobilePhone.SetUncheckIconVisible(false);

            // You can add additional actions or logic here as needed
        }
    }
}
