using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    private void Update()
    {
        float vectorY = _speed * Time.deltaTime;

        transform.Rotate(0, vectorY, 0);
    }
}