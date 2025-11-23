using UnityEngine;

public class E08_Script : MonoBehaviour
{
    public float numberA = 10f;
    public float numberB = 5f;

    public enum Operation { Add, Substract, Multiply, Divide }
    public Operation operation = Operation.Add;

    void Start()
    {
        float result = 0f;
        switch (operation)
        {
            case Operation.Add:
                result = numberA + numberB;
                break;
            case Operation.Substract:
                result = numberA - numberB;
                break;
            case Operation.Multiply:
                result = numberA * numberB;
                break;
            case Operation.Divide:
                if (numberB != 0f)
                    result = numberA / numberB;
                else
                    Debug.LogWarning("División por cero no permitida");
                break;
        }
        Debug.Log("Resultado:" + result);

    }
}
