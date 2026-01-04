using TMPro;
using UnityEngine;

public class E61_ScriptA : MonoBehaviour
{
    public float speed = 5f;

    public GameObject objectPrefab;

    public float destroyTime = 3f;

    public int counter = 0;

    public TMP_Text counterText;

    void Start()
    {
        UpdateCounterUI();
    }

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
            GameObject spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.identity);

            Destroy(spawnedObject, destroyTime);

            Invoke("Despawn", destroyTime);

            counter++;

            UpdateCounterUI();
        }
    }

    void Despawn()
    {
        counter--;

        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {
        if (counterText != null)
        {
            counterText.text = counter.ToString();
        }
    }
}
