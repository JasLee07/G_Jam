using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class FitBackgroundToCamera : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Camera cam = Camera.main;

        // Calculate camera dimensions in world units
        float worldHeight = cam.orthographicSize * 2f;
        float worldWidth = worldHeight * cam.aspect;

        // Get sprite dimensions in world units
        Vector2 spriteSize = sr.sprite.bounds.size;

        // Scale the object to fill the camera completely
        transform.localScale = new Vector3(
            worldWidth / spriteSize.x,
            worldHeight / spriteSize.y,
            1f
        );
        // Center on the camera (keeping the background's Z depth)
        transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, transform.position.z);
    }
}


