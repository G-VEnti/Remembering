using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{
    InputSystem_Actions inputs;
    private Vector2 lookInput;
    public float horizontalRotSpeed = 1.0f;
    public float verticalRotSpeed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputs = new InputSystem_Actions();
        inputs.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        lookInput = inputs.Player.Look.ReadValue<Vector2>();
        transform.localEulerAngles += new Vector3((lookInput.y * -verticalRotSpeed), (lookInput.x * horizontalRotSpeed), 0);
    }
}
