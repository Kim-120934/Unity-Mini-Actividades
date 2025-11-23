using UnityEngine;

public class E20_Script : MonoBehaviour
{
    
    public float velocidad = 5f;


    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");

        Vector3 direccion = new Vector3(inputHorizontal, inputVertical, 0f);

       direccion= direccion.normalized;

        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;

        transform.Translate(desplazamiento, Space.World);
    }
}
