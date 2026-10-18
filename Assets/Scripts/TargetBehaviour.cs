using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    public GameObject choppedTarget;
    private TargetManager targetM;
    public int score = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetM = gameObject.GetComponentInParent<TargetManager>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Bullet"))
        {
            targetM.destroyed = true;
            UIManager.instance.AddScore(score);
            Instantiate(choppedTarget, transform.position, transform.rotation);
            Destroy(gameObject);
        }   
    }
}
