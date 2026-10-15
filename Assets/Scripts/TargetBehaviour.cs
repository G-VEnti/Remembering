using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    public GameObject choppedTarget;
    private TargetManager targetM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetM = gameObject.GetComponentInParent<TargetManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Bullet"))
        {
            targetM.destroyed = true;
            Instantiate(choppedTarget, transform.position, transform.rotation);
            Destroy(gameObject);
            Debug.Log("Target hit");
        }   
    }
}
