using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class E30_Script : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(horizontal, vertical,0f);

        
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("El jugador entró en el objeto .");
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("El jugador salió del objeto.");
    }
}

