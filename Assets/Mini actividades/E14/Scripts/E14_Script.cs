using UnityEngine;

public class E14_Script : MonoBehaviour
{
    [Header("Rango de tablas")]
    public int inicioTabla = 1;
    public int finalTabla = 10;

    [Header("Rngo de multiplicadores")]
    public int multiplicadorInicial = 1;
    public int multiplicadorFinal = 10;

    void Start()
    {
        for (int i = inicioTabla; i <= finalTabla; i++)
        {
            Debug.Log($"Tabla del {i}:");


            for (int j = multiplicadorInicial; j <= multiplicadorFinal; j++)
            {
                int resultado = i * j;
                Debug.Log($"{i} x {j} = {resultado}");
            }

            Debug.Log("-----------------------");

        }
       }
  }
