using TMPro;
using UnityEngine;

public class E40_ScriptA : MonoBehaviour
{
    public int counter = 0;
    public TMP_Text counterText;

    public void AddPoints()
    {
        counter += 1;
        counterText.text = counter.ToString();

    }
}
