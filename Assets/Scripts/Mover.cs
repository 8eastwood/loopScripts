using UnityEngine;

public class Mover : MonoBehaviour
{
   
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.01f;
        transform.position = nextPosition;
    }
}
