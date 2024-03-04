using UnityEngine;

public class Bathroom_Wall1_Script : MonoBehaviour
{
    [SerializeField] private WaterController waterController; // Reference to the WaterController script
    [SerializeField] private GameObject waterGun; // Reference to the water gun GameObject
    [SerializeField] private Texture2D _dirtMaskBase;
    [SerializeField] private Texture2D _brush;
    [SerializeField] private Material _material;

    private Texture2D _templateDirtMask;
    private float dirtAmountTotal;
    public Bathroom_Wall1 Wall;

    private void Start()
    {
        CreateTexture();
    }

    private void Update()
    {
        // Check if the water controller's button is pressed
        if (waterController != null && waterController.isButtonPressed)
        {
            CleanWall();
        }
    }

    private void CleanWall()
    {
        RaycastHit hit;
        Ray ray = new Ray(waterGun.transform.position, waterGun.transform.forward);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("Bathroom_Wall1"))
            {
                Renderer renderer = hit.collider.GetComponent<Renderer>();
                Texture2D dirtMaskTexture = renderer.material.GetTexture("_DirtMask") as Texture2D;

                if (dirtMaskTexture != null)
                {
                    Vector2 textureCoord = hit.textureCoord;
                    Vector2 pixelUV = new Vector2(textureCoord.x * dirtMaskTexture.width, textureCoord.y * dirtMaskTexture.height);

                    int pixelX = Mathf.RoundToInt(pixelUV.x);
                    int pixelY = Mathf.RoundToInt(pixelUV.y);

                    for (int x = pixelX - _brush.width / 2; x < pixelX + _brush.width / 2; x++)
                    {
                        for (int y = pixelY - _brush.height / 2; y < pixelY + _brush.height / 2; y++)
                        {
                            if (x >= 0 && x < dirtMaskTexture.width && y >= 0 && y < dirtMaskTexture.height)
                            {
                                float distance = Vector2.Distance(new Vector2(x, y), pixelUV);

                                if (distance <= _brush.width / 2)
                                {
                                    Color pixelDirt = _brush.GetPixel(x - (pixelX - _brush.width / 2), y - (pixelY - _brush.height / 2));
                                    Color pixelDirtMask = dirtMaskTexture.GetPixel(x, y);

                                    dirtMaskTexture.SetPixel(x, y, Color.Lerp(pixelDirtMask, Color.clear, pixelDirt.g));
                                }
                            }
                        }
                    }

                    dirtMaskTexture.Apply();

                    int cleanAmount = CalculateCleanPercentage();
                    Debug.Log("Percentage of Clean Area: " + cleanAmount + "%");

                    Wall.wall1(cleanAmount);
                    MaterialManager.UpdateMaterialValue("Wall 1");
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
