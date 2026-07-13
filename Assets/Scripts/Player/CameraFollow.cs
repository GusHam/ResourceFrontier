using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        transform.position = target.position + new Vector3(0f, 10f, -10f);
        transform.LookAt(target);
    }
    
}
