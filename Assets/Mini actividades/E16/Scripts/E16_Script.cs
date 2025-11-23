using UnityEngine;

public class E16_Script : MonoBehaviour
{
   
    
    public float velocidad = 3f;

    private Vector3 direccion = new Vector3(1f, -1f, 0f);

    void Start()
    {
        direccion = direccion.normalized;
    }

    void Update()
    {
        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;

        transform.position += desplazamiento;
    }
  

}