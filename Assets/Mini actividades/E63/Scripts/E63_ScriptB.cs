using UnityEngine;

public class E63_ScriptB : MonoBehaviour
{
    public AudioClip coinSound;

    public string playerTag = "Player";

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            if (coinSound != null)
            {
                AudioSource.PlayClipAtPoint(coinSound, transform.position);
            }
            else
            {
                Debug.LogWarning("No hay AudioClip asignado!");
            }
        }
    }

}
