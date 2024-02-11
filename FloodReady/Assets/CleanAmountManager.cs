using UnityEngine;

public class CleanAmountManager : MonoBehaviour
{
    public static int CleanAmountValue { get; private set; }

    public static void UpdateCleanAmount(int amount)
    {
        CleanAmountValue = amount;
    }
}
