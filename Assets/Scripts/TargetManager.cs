using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public bool destroyed = true;
    private float timer;
    private float respawnTime = 3.0f;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyed) timer += Time.deltaTime;

        if (timer >= respawnTime)
        {
            Instantiate(target, transform.position, transform.rotation, transform);
            destroyed = false;
            timer = 0;
        }
    }
}
