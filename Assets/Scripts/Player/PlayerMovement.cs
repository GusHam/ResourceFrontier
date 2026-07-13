using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField]
    private float moveSpeed = 5f;

    private InputAction moveAction;

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Player/Move");
    }
    
    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();

        Vector3 movement = new Vector3(input.x, 0f, input.y);

        if (movement != Vector3.zero)
        {
            transform.forward = movement;
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime,  Space.World);
    }
}
