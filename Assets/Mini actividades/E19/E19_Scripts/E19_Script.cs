using UnityEngine;

public class E19_Script : MonoBehaviour
{
    
    public float velocidad = 5f;
 
   
    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

       Vector3 direccion = new Vector3(inputHorizontal, inputVertical, 0f);

        Vector3 desplazamiento = direccion.normalized * velocidad * Time.deltaTime;

            transform.position += desplazamiento;
    }
}
