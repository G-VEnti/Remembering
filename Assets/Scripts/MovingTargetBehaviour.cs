using System.Collections.Generic;
using UnityEngine;

public class MovingTargetBehaviour : MonoBehaviour
{
    [SerializeField] private List<GameObject> locations = new List<GameObject>();
    private int locationPointer;
    public int score = 500;
    public float speed = 1.0f;
    private float step;
    private bool changeDir = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locationPointer = 0;
        transform.position = locations[locationPointer].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        if (locationPointer >= locations.Count)
        {
            changeDir = true;
            locationPointer--;
        }
        if (locationPointer < 0)
        {
            changeDir = false;
            locationPointer = 0;
        }

        if (transform.position == locations[locationPointer].transform.position)
        {
            locationPointer = (changeDir) ? locationPointer -= 1 : locationPointer += 1;
            Debug.Log(locationPointer);
        }
        else transform.position = Vector3.MoveTowards(transform.position, locations[locationPointer].transform.position, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Bullet"))
        {
            UIManager.instance.AddScore(score);
        }
    }
}
