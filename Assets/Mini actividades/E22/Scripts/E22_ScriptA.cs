using UnityEngine;

public class E22_Script : MonoBehaviour
{
    public Transform objetivo;

    public float velocidadMax = 5f;

    public float suavizado = 5f;

    private float velocidadActual = 0f;
    
    void Update()
    {
        if(objetivo == null) return;

        float distancia = Vector3.Distance(transform.position, objetivo.position);

        float velocidadDeseada= distancia*suavizado;

        velocidadDeseada = Mathf.Clamp(velocidadDeseada, 0f, velocidadMax);

        velocidadActual = Mathf.Lerp(velocidadActual, velocidadDeseada, Time.deltaTime * 3f);

        transform.position = Vector3.MoveTowards(
            transform.position,      
            objetivo.position,
            velocidadActual * Time.deltaTime
            );
    }
}
