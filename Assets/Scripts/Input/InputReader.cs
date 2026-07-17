using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour, IInputReader
{
    public Vector2 Movement { get; private set; }

    private InputAction moveAction;

    public void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Player/Move");
    }

    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();
    }
}
