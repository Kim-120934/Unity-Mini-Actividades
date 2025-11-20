using UnityEngine;

public class E32_ScriptB : MonoBehaviour
{
    void Start()
    {
        
        gameObject.tag = "Player";
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {

        if (collision.tag == "Enemy")
        {
            Debug.Log("Triggered by Enemy");
        }
        else if (collision.tag == "Ally")
        {
            Debug.Log("Triggered by Ally");
        }
    }
}
