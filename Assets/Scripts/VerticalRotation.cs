using UnityEngine;

public class VerticalRotation : MonoBehaviour
{
    public float rotSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(-InputManager.instance.mouseAxis.y, 0, 0) * rotSpeed;
    }
}