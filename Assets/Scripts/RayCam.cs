using UnityEngine;

public class RayCam : MonoBehaviour
{
    public Vector3 direction;
    public float distance;
    public GameObject cam;
    private Vector3 hitPosition;
    void Update()
    {
        direction = (cam.transform.position - transform.position).normalized;

        RaycastHit hit;

        Debug.DrawRay(transform.position, direction * distance, Color.red);

        if (Physics.Raycast(transform.position, direction, out hit, distance))
        {
            Debug.DrawRay(transform.position, direction * distance, Color.green);
            hitPosition = hit.point;
        }
        else
        {
            hitPosition = transform.position + direction * distance;
        }

        cam.transform.position = hitPosition;

    }
}
