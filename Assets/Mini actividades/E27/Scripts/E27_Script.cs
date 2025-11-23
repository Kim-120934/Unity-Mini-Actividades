using UnityEngine;

public class E27_Script : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 direccion;

    void Update()
    {
        direccion = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W)) direccion.y = 1;
        if (Input.GetKey(KeyCode.S)) direccion.y = -1;
        if (Input.GetKey(KeyCode.A)) direccion.x = -1;
        if (Input.GetKey(KeyCode.D)) direccion.x = 1;

       
        transform.position += direccion * velocidad * Time.deltaTime;
    }
}