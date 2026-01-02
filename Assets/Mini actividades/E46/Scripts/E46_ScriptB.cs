using UnityEngine;

public class E46_ScriptB : MonoBehaviour
{
    public Transform target;

    
    public float followSpeed = 3f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (target != null && rb != null)
        {
            Vector3 direction = target.position - transform.position;

            direction.Normalize();

            Vector2 desiredVelocity = direction * followSpeed;

            rb.linearVelocity = new Vector2(desiredVelocity.x, rb.linearVelocity.y);
        }
    }
}
