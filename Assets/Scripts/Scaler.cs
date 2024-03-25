using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _newScale = new Vector3(3f, 3f, 3f);

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _newScale, _speed * Time.deltaTime);
    }
}
