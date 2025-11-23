using UnityEngine;

public class E25_Script : MonoBehaviour
{

    private float impulseForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();


        if (rb != null)
        {
            rb.AddForce(Vector2.up * impulseForce, ForceMode2D.Impulse);
        }

    }
}