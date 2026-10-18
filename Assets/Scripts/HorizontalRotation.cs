using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HorizontalRotation : MonoBehaviour
{    
    public float rotSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles += new Vector3(0, InputManager.instance.mouseAxis.x, 0) * rotSpeed;
    }
}
