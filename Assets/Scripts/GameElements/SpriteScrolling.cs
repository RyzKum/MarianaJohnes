using UnityEngine;

public class SpriteScrolling : MonoBehaviour
{
    public float scrollSpeedX = 0.2f;
    public float scrollSpeedY = 0f;

    private Material material;

    private void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        material = renderer.material;
    }

    private void Update()
    {
        material.SetFloat("_ScrollSpeedX", scrollSpeedX);
        material.SetFloat("_ScrollSpeedY", scrollSpeedY);
    }
}