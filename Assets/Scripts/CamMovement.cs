using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float vSpeed;
    public float hSpeed;
    public float vMove;
    public float hMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hMove = InputManager.instance.movement.x * hSpeed * Time.deltaTime;
        vMove = InputManager.instance.movement.y * vSpeed * Time.deltaTime;

        transform.position += new Vector3(hMove, vMove, 0);
    }
}
