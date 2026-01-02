using UnityEngine;

public class E52_ScriptA : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (Input.GetMouseButtonDown(1))
        {
            spriteRenderer.flipY = !spriteRenderer.flipY;
        }
    }
}
