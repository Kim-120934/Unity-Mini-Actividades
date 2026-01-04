using UnityEngine;

public class E59_ScriptA : MonoBehaviour
{
    public float speed = 5f;

    public GameObject objectPrefab;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        if (objectPrefab != null)
        {
            Instantiate(objectPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("No hay prefab asignado para spawnear!");
        }
    }
}
