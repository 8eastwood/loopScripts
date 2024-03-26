using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private static int _scaleFactor = 3;

    private Vector3 _newScale = Vector3.one * _scaleFactor;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _newScale, _speed * Time.deltaTime);
    }
}
