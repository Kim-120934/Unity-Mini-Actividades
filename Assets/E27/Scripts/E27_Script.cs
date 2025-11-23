using UnityEngine;

public class E27_Script : MonoBehaviour

{
  
    public float speed = 5f;

   
    public bool allowVerticalInput = false;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void FixedUpdate()
    {
        
        float h = Input.GetAxisRaw("Horizontal"); 
        float v = Input.GetAxisRaw("Vertical");  

       
        Vector2 input = new Vector2(h, allowVerticalInput ? v : 0f);
        if (input.sqrMagnitude > 1f) input = input.normalized;

        Vector3 displacement = new Vector3(
            input.x * speed * Time.fixedDeltaTime,
            input.y * speed * Time.fixedDeltaTime,
            0f
        );

        
        transform.position += displacement;

     
    }
}
