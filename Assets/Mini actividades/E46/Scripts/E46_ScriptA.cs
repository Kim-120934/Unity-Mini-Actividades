using TMPro;
using UnityEngine;

public class E46_ScriptA : MonoBehaviour
{
    public float speed = 5f;
    


    void Update()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        Vector3 move = new Vector3(moveX, moveY, 0f) * speed * Time.deltaTime;
        transform.position += move;
    }
}
