using UnityEngine;

public class E31_ScriptA : MonoBehaviour
{
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color = Color.red;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = Color.white;
    }
}
