using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;

    void Update()
    {
        float vectorX = _speed* Time.deltaTime;

        transform.Translate(vectorX, 0, 0);
    }
}