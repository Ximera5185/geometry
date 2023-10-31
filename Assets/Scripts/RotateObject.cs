using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}