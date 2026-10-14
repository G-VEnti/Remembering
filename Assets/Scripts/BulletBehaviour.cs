using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody rgbBullet;
    [SerializeField] private float thrust = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgbBullet.AddForce(transform.up * thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
