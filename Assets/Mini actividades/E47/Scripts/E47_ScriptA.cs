using UnityEngine;

public class E47_ScriptA : MonoBehaviour
{
    public Transform target;

    public float followSpeed = 3f;

    public float detectionDistance = 5f;

    void Update()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);

            if (distance < detectionDistance)
            {
                Vector3 direction = target.position - transform.position;

                direction.Normalize();

                transform.position += direction * followSpeed * Time.deltaTime;
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionDistance);
    }
}
