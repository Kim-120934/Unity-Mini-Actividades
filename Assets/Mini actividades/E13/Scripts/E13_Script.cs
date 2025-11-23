using UnityEngine;

public class E13_Script : MonoBehaviour
{
    
    void Start()
    {
        int count = 0;
        while (count < 100)
        {
            float randomNumber = Random.Range(0f, 100f);
            Debug.Log(randomNumber);
            count++;
        }
        
    }

}
