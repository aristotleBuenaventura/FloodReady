using UnityEngine;

public class CleanAmountManager : MonoBehaviour
{
    public static double CleanAmountValue { get; private set; }

    public static void UpdateCleanAmount(double amount)
    {
        CleanAmountValue = amount;
    }
}
