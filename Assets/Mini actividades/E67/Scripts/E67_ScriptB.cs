using UnityEngine;
using UnityEngine.SceneManagement;

public class E67_ScriptB : MonoBehaviour
{
    public string targetSceneName = "e67_blue";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
