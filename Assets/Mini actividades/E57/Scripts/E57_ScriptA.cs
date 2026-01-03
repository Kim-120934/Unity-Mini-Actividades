using UnityEngine;

public class E57_ScriptA : MonoBehaviour
{
    public float speed = 5f;

    public float explosionRadius = 3f;

    public float explosionForce = 500f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateExplosion();
        }
    }

    void CreateExplosion()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].attachedRigidbody != null)
            {
                if (colliders[i].gameObject != gameObject)
                {
                    Vector2 direction = colliders[i].transform.position - transform.position;

                    direction.Normalize();

                    colliders[i].attachedRigidbody.AddForce(direction * explosionForce);
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
