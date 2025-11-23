using UnityEngine;

public class E15_Scripti : MonoBehaviour
{
    string[] opciones = { "Rock", "Paper", "Scissors" };

    void Start()
    {
        int jugadorGana = 0;
        int ordenadorGana = 0;
        int ronda = 1;

        
        while (jugadorGana < 3 && ordenadorGana < 3 && ronda <= 5)
        {
            Debug.Log($"--- Ronda {ronda} ---");

           
            int jugadorElige = Random.Range(0, 3);
            int ordenadorElige = Random.Range(0, 3);

            Debug.Log($"Jugador elige: {opciones[jugadorElige]}");
            Debug.Log($"Ordenador elige: {opciones[ordenadorElige]}");

            
            if (jugadorElige == ordenadorElige)
            {
                Debug.Log("Empate!");
            }
            else if (
                (jugadorElige == 0 && ordenadorElige == 2) || 
                (jugadorElige == 1 && ordenadorElige == 0) || 
                (jugadorElige == 2 && ordenadorElige == 1)    
            )
            {
                Debug.Log("El jugador gana esta ronda!");
                jugadorGana++;
            }
            else
            {
                Debug.Log("El ordenador gana esta ronda!");
                ordenadorGana++;
            }

            Debug.Log($"Puntuación => Jugador: {jugadorGana} | Ordenador: {ordenadorGana}");
            Debug.Log("-----------------------------");

            ronda++;
        }

       
        if (jugadorGana > ordenadorGana)
            Debug.Log("El jugador gana!");
        else if (ordenadorGana > jugadorGana)
            Debug.Log("El ordenador gana!");
        else
            Debug.Log("Empate!");
    }
}