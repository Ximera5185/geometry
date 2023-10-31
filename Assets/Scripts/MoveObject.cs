using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] float _speedMove = 10f;

    void Update()
    {
        transform.Translate(_speedMove * Time.deltaTime, 0, 0);
    }
}