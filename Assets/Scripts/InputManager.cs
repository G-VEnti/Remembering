using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    public InputSystem_Actions inputs;
    public Vector2 mouseAxis;
    public Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            inputs = new InputSystem_Actions();
            inputs.Enable();
        }
        else Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        mouseAxis = inputs.Player.Look.ReadValue<Vector2>();
        movement = inputs.Player.Move.ReadValue<Vector2>();
    }
}
