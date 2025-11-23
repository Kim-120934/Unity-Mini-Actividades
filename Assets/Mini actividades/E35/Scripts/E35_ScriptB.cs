using UnityEngine;

public class E35_ScriptB : MonoBehaviour
{
    [SerializeField] private Transform target;       
    [SerializeField] private float maxFollowSpeed = 5f;
    [SerializeField] private Vector3 offset;        

    private void LateUpdate()
    {
        if (target == null) return;

        
        Vector3 desiredPosition = target.position + offset;

        
        transform.position = Vector3.MoveTowards(
            transform.position,
            desiredPosition,
            maxFollowSpeed * Time.deltaTime
        );
    }
}
