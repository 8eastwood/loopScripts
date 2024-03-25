using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private int _speed;

    void Update()
    {
        Spin();
    }

    private void Spin()
    {
        transform.RotateAround(transform.position, transform.up, 2f  * _speed * Time.deltaTime);
    }
}
