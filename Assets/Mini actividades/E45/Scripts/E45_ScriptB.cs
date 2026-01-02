using UnityEngine;

public class E45_ScriptB : MonoBehaviour
{
    public Transform cameraTransform;

    
    [Range(0f, 1f)]
    public float parallaxFactor = 0.5f;

    
    public Vector3 offset;

    
    private Vector3 previousCameraPosition;

    void Start()
    {
        
        if (cameraTransform != null)
        {
            previousCameraPosition = cameraTransform.position;
        }
    }

    void Update()
    {
        if (cameraTransform != null)
        {
            
            Vector3 cameraMovement = cameraTransform.position - previousCameraPosition;

            
            transform.position += cameraMovement * parallaxFactor;

           
            previousCameraPosition = cameraTransform.position;
        }
    }
}
