using UnityEngine;

public class Scales : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        float vectorX = _speed * Time.deltaTime;
        float VectorY = _speed * Time.deltaTime;
        float VectorZ = _speed * Time.deltaTime;

        transform.localScale += new Vector3(vectorX, VectorY, VectorZ);
    }
}