using UnityEngine;

public class E30_ScriptB : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Debug.Log("El jugador ha entrado en el objeto ");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            Debug.Log("El jugador ha salido del objeto ");
        }
    }
}
