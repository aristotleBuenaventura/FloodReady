using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public static string MaterialValue { get; private set; }

    public static void UpdateMaterialValue(string material)
    {
        MaterialValue = material;
    }
}
