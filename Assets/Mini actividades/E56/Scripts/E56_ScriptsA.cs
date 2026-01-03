using UnityEngine;

public class E56_ScriptsA : MonoBehaviour
{
    public float speed = 5f;

    public float destructionRadius = 3f;

    public string targetTag = "Destructible";

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DestroyNearbyObjects();
        }
    }

    void DestroyNearbyObjects()
    {
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag(targetTag);

        foreach (GameObject obj in allObjects)
        {
            float distance = Vector3.Distance(transform.position, obj.transform.position);

            if (distance < destructionRadius)
            {
                Destroy(obj);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, destructionRadius);
    }
}
