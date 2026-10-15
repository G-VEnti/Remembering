using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private Rigidbody rgbBullet;
    [SerializeField] private float thrust = 1.0f;

    private float despawnTime = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgbBullet.AddForce(transform.up * thrust, ForceMode.Impulse);
        Destroy(gameObject, despawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
