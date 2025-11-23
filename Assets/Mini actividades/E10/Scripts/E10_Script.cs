using UnityEngine;

public class E10_Script : MonoBehaviour
{
    public float minValue = -10f;
    public float maxValue = 10f;
    enum Operation { Add, Substract, Multiply, Divide, Modulo }

    void Start()
    {
        float numberA = Random.Range(minValue, maxValue);
        float numberB = Random.Range(minValue, maxValue);
        
        Operation op =(Operation) Random.Range(0, 5);

        float result = 0f;
        string opSymbol = "";
        
        switch(op)
        {
            case Operation.Add:
                result = numberA + numberB;
                opSymbol = "+";
                break;
            case Operation.Substract:
                result = numberA - numberB;
                opSymbol = "-";
                break;
            case Operation.Multiply:
                result = numberA * numberB;
                opSymbol = "*";
                break;
            case Operation.Divide:
                if (numberB != 0f)
                    result = numberA / numberB;
                else
                    Debug.LogWarning("División por cero, se omite");
                opSymbol = "/";
                break;
            case Operation.Modulo:
                if (numberB != 0f)
                    result = numberA % numberB;
                else
                    Debug.LogWarning("Módulo por cero, se omite");
                opSymbol = "%";
                break;
        }
        Debug.Log(numberA +" " + opSymbol + " " + numberB +"=" + result);
    }

}
