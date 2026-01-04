using TMPro;
using UnityEngine;

public class E60_ScriptA : MonoBehaviour
{
    public float speed = 5f;

    public GameObject objectPrefab;

    public int counter = 0;

    public TMP_Text counterText;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objectPrefab != null)
            {
                Instantiate(objectPrefab, transform.position, Quaternion.identity);
            }

            counter++;

            if (counterText != null)
            {
                counterText.text = counter.ToString();
            }
        }
    }
}
