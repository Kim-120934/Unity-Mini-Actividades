using UnityEngine;

public class E58_ScriptA : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipGravity();
        }
    }

    void FlipGravity()
    {
        Physics2D.gravity *= -1;

        Debug.Log("Nueva gravedad: " + Physics2D.gravity);
    }
}
