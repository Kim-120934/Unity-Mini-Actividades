using TMPro;
using UnityEngine;

public class E43_ScriptA : MonoBehaviour
{
     public float speed = 5f;
     public TMP_Text pointsText;
     public int points = 0;


    void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal"); 
        float moveY = Input.GetAxis("Vertical");


        Vector3 move = new Vector3(moveX, moveY, 0f) * speed * Time.deltaTime;
        transform.position += move;
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(other.gameObject);

        
        points += 1;

       pointsText.text= points.ToString();
    
    }
}
