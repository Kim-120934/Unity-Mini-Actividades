using UnityEngine;

public class E55_ScriptA : MonoBehaviour
{
    private Animator animator;

    private bool isWalking = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isWalking = !isWalking;

            animator.SetBool("isWalking", isWalking);
        }
    }
}
