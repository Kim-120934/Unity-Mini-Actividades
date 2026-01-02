using UnityEngine;

public class E48_ScriptA : MonoBehaviour
{
    public Transform target;

    public float followSpeed = 5f;

    public float fixedY = 0f;

    void Start()
    {
        fixedY = transform.position.y;
    }

    void Update()
    {
        if (target != null)
        {
            float directionX = target.position.x - transform.position.x;

            float normalizedDirectionX = Mathf.Sign(directionX);

            float newX = transform.position.x + normalizedDirectionX * followSpeed * Time.deltaTime;

            transform.position = new Vector3(newX, fixedY, transform.position.z);
        }
    }
}
