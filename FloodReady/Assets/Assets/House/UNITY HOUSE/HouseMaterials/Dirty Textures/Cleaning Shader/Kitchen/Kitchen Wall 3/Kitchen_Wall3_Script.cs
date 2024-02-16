// Add this line at the beginning of your script
using UnityEngine;

public class Kitchen_Wall3_Script : MonoBehaviour
{
    [SerializeField] private GameObject waterGun; // Reference to the water gun GameObject
    [SerializeField] private Texture2D _dirtMaskBase;
    [SerializeField] private Texture2D _brush;
    [SerializeField] private Material _material;

    private Texture2D _templateDirtMask;
    private float dirtAmountTotal;

    private void Start()
    {
        CreateTexture();
    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.SecondaryIndexTrigger))
        {
            RaycastHit hit;
            Ray ray = new Ray(waterGun.transform.position, waterGun.transform.forward);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Kitchen_Wall3")) // Check if the object hit has the tag "Plug"
                {
                    Vector2 textureCoord = hit.textureCoord;

                    int pixelX = (int)(textureCoord.x * _templateDirtMask.width);
                    int pixelY = (int)(textureCoord.y * _templateDirtMask.height);

                    for (int x = 0; x < _brush.width; x++)
                    {
                        for (int y = 0; y < _brush.height; y++)
                        {
                            Color pixelDirt = _brush.GetPixel(x, y);
                            Color pixelDirtMask = _templateDirtMask.GetPixel(pixelX + x, pixelY + y);

                            // Use lerping for smooth transitions
                            _templateDirtMask.SetPixel(pixelX + x, pixelY + y, Color.Lerp(pixelDirtMask, Color.clear, pixelDirt.g));
                        }
                    }

                    _templateDirtMask.Apply();

                    // Calculate and log the percentage of clean area
                    int cleanAmount = CalculateCleanPercentage();
                    Debug.Log("Percentage of Clean Area: " + cleanAmount + "%");

                    // Update clean amount value in CleanAmountManager
                    CleanAmountManager.UpdateCleanAmount(cleanAmount);
                    MaterialManager.UpdateMaterialValue("Wall 3");
                }
            }
        }
    }

    private void CreateTexture()
    {
        _templateDirtMask = new Texture2D(_dirtMaskBase.width, _dirtMaskBase.height);
        _templateDirtMask.SetPixels(_dirtMaskBase.GetPixels());
        _templateDirtMask.Apply();

        _material.SetTexture("_DirtMask", _templateDirtMask);

        dirtAmountTotal = CalculateInitialDirtAmount();
    }

    private float CalculateInitialDirtAmount()
    {
        float totalDirt = 0f;

        for (int x = 0; x < _dirtMaskBase.width; x++)
        {
            for (int y = 0; y < _dirtMaskBase.height; y++)
            {
                totalDirt += _dirtMaskBase.GetPixel(x, y).g;
            }
        }

        return totalDirt;
    }

    private int CalculateCleanPercentage()
    {
        float cleanAmount = 0f;

        for (int x = 0; x < _templateDirtMask.width; x++)
        {
            for (int y = 0; y < _templateDirtMask.height; y++)
            {
                cleanAmount += _templateDirtMask.GetPixel(x, y).g;
            }
        }

        float percentage = 1f - cleanAmount / dirtAmountTotal;
        int roundedPercentage = Mathf.RoundToInt(percentage * 100f);

        return roundedPercentage;
    }
}
