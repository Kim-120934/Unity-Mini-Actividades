using UnityEngine;

public class E08_ScriptA : MonoBehaviour
{
    public float number = 5f;
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            float result = number * i;
            Debug.Log(number + "x" + i + "=" + result);
        }
    }
}
