using UnityEngine;

public class E67_ScriptA : MonoBehaviour
{
    private static E67_ScriptA instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
