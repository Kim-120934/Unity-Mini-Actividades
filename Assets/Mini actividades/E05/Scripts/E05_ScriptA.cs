using UnityEngine;

public class E05_ScriptA : MonoBehaviour
{
    public float numberA = 3.5f;
    public float numberB = 2.5f;

    void Start()
    {
        float result = numberA + numberB;
        Debug.Log("La suma es:" + result);
    }

   
}
