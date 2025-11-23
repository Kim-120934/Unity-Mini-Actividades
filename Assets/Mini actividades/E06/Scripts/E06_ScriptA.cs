using UnityEngine;

public class E06_ScriptA : MonoBehaviour
{
    public int numberA = 10;
    public int numberB = 10;
    public int numberC = 10;

    void Start()
    {
        float average = (numberA + numberB + numberC / 3f);
        Debug.Log("El promedio es;" + average);
    }

   
}
