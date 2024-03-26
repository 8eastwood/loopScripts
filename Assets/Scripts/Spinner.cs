using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private int _speed;

    private void Update()
    {
        Spin();
    }

    private void Spin()
    {
        transform.Rotate(0 * _speed, 5 * _speed, 0 * _speed);
    }
}
