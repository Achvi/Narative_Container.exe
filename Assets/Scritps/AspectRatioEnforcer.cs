using UnityEngine;

public class AspectRatioEnforcer : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private float targetAspect = 1f; // 1:1 for square

    void Start()
    {
        // Ensure the camera clears with black
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
        mainCamera.backgroundColor = Color.black;
        UpdateCamera();
    }

    void UpdateCamera()
    {
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleWidth = targetAspect / windowAspect;

        if (scaleWidth < 1f) // Screen is wider than square (e.g., 16:9)
        {
            Rect rect = mainCamera.rect;
            rect.width = scaleWidth;
            rect.height = 1f;
            rect.x = (1f - scaleWidth) / 2f; // Center the square with vertical bars
            rect.y = 0f;
            mainCamera.rect = rect;
        }
        else // Screen is square or taller (e.g., 1:1 or 9:16)
        {
            Rect rect = mainCamera.rect;
            rect.width = 1f;
            rect.height = 1f / scaleWidth; // Adjust height for taller screens
            rect.x = 0f;
            rect.y = (1f - (1f / scaleWidth)) / 2f; // Center with horizontal bars if needed
            mainCamera.rect = rect;
        }
    }

    void OnValidate() // Update when scene is edited
    {
        UpdateCamera();
    }
}