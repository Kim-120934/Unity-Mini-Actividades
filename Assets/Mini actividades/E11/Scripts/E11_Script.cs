using UnityEngine;

public class E11_Script : MonoBehaviour
{
    [Range(1, 3)]
    public int playerChoice = 1; //El jugador elige su jugada (Piedra=1, Papel=2, Tijeras=3)

    void Start()
    {
        
        int aiChoice = Random.Range(1, 4); 

      
        string playerHand = "";
        string aiHand = "";

        switch (playerChoice)
        {
            case 1: playerHand = "Rock"; break;
            case 2: playerHand = "Paper"; break;
            case 3: playerHand = "Scissors"; break;
        }

        switch (aiChoice)
        {
            case 1: aiHand = "Rock"; break;
            case 2: aiHand = "Paper"; break;
            case 3: aiHand = "Scissors"; break;
        }

      
        string result = "";

        if (playerChoice == aiChoice)
        {
            result = "Empate";
        }
        else if ((playerChoice == 1 && aiChoice == 3) ||
                 (playerChoice == 2 && aiChoice == 1) ||
                 (playerChoice == 3 && aiChoice == 2))
        {
            result = "Jugador gana";
        }
        else
        {
            result = "IA gana";
        }

       
        Debug.Log("Jugador: " + playerHand + " | IA: " + aiHand + " | Resultado: " + result);
    }
}
