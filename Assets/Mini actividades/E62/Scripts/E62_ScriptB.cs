using UnityEngine;

public class E62_ScriptB : MonoBehaviour
{
    public Transform targetTeleporter;

    public string playerTag = "Player";

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Algo entró al trigger: " + other.gameObject.name);

        if (other.CompareTag(playerTag))
        {
            Debug.Log("Es el jugador!");

            if (targetTeleporter != null)
            {
                Debug.Log("Teletransportando a: " + targetTeleporter.position);
                other.transform.position = targetTeleporter.position;
            }
            else
            {
                Debug.LogWarning("No hay target teleporter asignado!");
            }
        }
        else
        {
            Debug.Log("No es el jugador. Tag actual: " + other.tag);
        }
    }
}
