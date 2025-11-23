using UnityEngine;

public class E17 : MonoBehaviour
{
   
    public float velocidad = 5f;

    private Vector3 direccion = new Vector3 (-1f, -1f, 0f);

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
