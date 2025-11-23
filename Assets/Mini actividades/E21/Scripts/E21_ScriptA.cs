using UnityEngine;

public class E21_Script : MonoBehaviour
{
   
    public Transform objetivo;

    void Update()
    {
        if (objetivo != null)
        {
            transform.position = objetivo.position;
        }
    }
}
