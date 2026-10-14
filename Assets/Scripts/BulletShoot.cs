using System.Diagnostics;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.instance.inputs.Player.Jump.WasPressedThisFrame())
        {
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
