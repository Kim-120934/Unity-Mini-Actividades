using UnityEngine;
using UnityEngine.SceneManagement;

public class E66_ScriptA : MonoBehaviour
{
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("E66_rojo");
        }

        if (timer >= 10f)
        {
            SceneManager.LoadScene("E66_verde");
        }
    }

    public void LoadBlue()
    {
        SceneManager.LoadScene("E66_azul");
    }
}

