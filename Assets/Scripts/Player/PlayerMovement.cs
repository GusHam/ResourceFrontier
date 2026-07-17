using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private InputReader inputReader;

    private IInputReader reader;

    public void Awake()
    {
        reader = inputReader;
    }
    
    void Update()
    {
        Vector2 input = reader.Movement;

        Vector3 movement = new Vector3(input.x, 0f, input.y);

        if (movement != Vector3.zero)
        {
            transform.forward = movement;
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime,  Space.World);
    }
}
