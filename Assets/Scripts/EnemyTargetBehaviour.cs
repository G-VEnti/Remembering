using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyTargetBehaviour : MonoBehaviour
{
    [SerializeField] private List<GameObject> locations = new List<GameObject>();
    private int locationPointer;
    public int score = 100;
    public float speed = 1.0f;
    private float step;
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
        if (locationPointer >= locations.Count) locationPointer = 0;
        if (transform.position == locations[locationPointer].transform.position) locationPointer++;
        else transform.position = Vector3.MoveTowards(transform.position, locations[locationPointer].transform.position, step);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other != null && other.CompareTag("Bullet"))
        {
            UIManager.instance.SubtractScore(score);
        }
    }
}
