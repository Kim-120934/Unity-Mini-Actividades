using UnityEngine;

public class E41_ScriptA : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3 (moveX, moveY, 0f) * speed * Time.deltaTime; 
        transform.position += move;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Destruye cualquier objeto que toque
        Destroy(other.gameObject);
    }

}
