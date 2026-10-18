using System.Collections.Generic;
using UnityEngine;

public class MovingTargetBehaviour : MonoBehaviour
{
    private MovingTargetManager targetM;
    public GameObject choppedTarget;

    public int score = 500;
    void Start()
    {
        targetM = gameObject.GetComponentInParent<MovingTargetManager>();
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
