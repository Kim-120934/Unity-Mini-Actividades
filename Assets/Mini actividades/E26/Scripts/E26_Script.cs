using UnityEngine;

public class E26_Script : MonoBehaviour
{
    Rigidbody2D rb;

   
    public float fuerzaSalto = 7f;

   
    bool enSuelo = false;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    [System.Obsolete]
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
           
            Saltar();
        }
    }

    [System.Obsolete]
    void Saltar()
    {
        
        rb.velocity = new Vector2(rb.velocity.x, 0);

       
        rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);

       
        enSuelo = false;
    }

   

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("Suelo"))
        {
            enSuelo = false;
        }
    }
}
