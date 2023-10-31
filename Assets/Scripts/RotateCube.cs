using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] GameObject _linghtObject;

    public float speed = 10f;

    private float _rotationAngle = 10;
    private float minValueTime = 1f;
    private float maxValueTime = 5f;

    
    private void Update()
    {
        if (_gameManager.time > minValueTime && _gameManager.time < maxValueTime)
        {
            _linghtObject.SetActive(true);

            transform.Rotate(0, _rotationAngle * speed * Time.deltaTime, 0);
        }
        else 
        {
            _linghtObject.SetActive(false);
        }
    }
}
