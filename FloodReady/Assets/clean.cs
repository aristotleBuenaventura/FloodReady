using UnityEngine;

public class Clean : MonoBehaviour
{
    [SerializeField] private GameObject waterGun; // Reference to the water gun GameObject
    [SerializeField] private Texture2D _dirtMaskBase;
    [SerializeField] private Texture2D _brush;
    [SerializeField] private Material _material;

    private Texture2D _templateDirtMask;

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
            }
        }
    }

    private void CreateTexture()
    {
        _templateDirtMask = new Texture2D(_dirtMaskBase.width, _dirtMaskBase.height);
        _templateDirtMask.SetPixels(_dirtMaskBase.GetPixels());
        _templateDirtMask.Apply();

        _material.SetTexture("_DirtMask", _templateDirtMask);
    }
}
