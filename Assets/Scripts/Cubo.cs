using UnityEngine;

public class Cubo : MonoBehaviour
{
    void Start()
    {
        /*if (Physics.Raycast(transform.position, transform.up))
        {
            Destroy(gameObject);
        }*/

        if (Physics.Raycast(transform.position, transform.up) &&
           Physics.Raycast(transform.position, -transform.up) &&
           Physics.Raycast(transform.position, transform.right) &&
           Physics.Raycast(transform.position, -transform.right) &&
           Physics.Raycast(transform.position, transform.forward) &&
           Physics.Raycast(transform.position, -transform.forward))
        {
            Destroy(gameObject);
        }
    }
}
