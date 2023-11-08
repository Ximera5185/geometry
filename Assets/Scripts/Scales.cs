using UnityEngine;

public class Scales : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}