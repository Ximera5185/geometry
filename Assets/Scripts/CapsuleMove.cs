using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMove : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] GameObject _linghtObject;

    public float speedScale = 1;

    private float _minValueTime = 21f;
    private float _maxValueTime = 25f;

    private float _speedPosY = 1;

    private void Update()
    {
        if (_gameManager.time > _minValueTime && _gameManager.time < _maxValueTime)
        {
            _linghtObject.SetActive(true);

            transform.Translate(0, _speedPosY * Time.deltaTime, 0);

            transform.localScale += new Vector3(speedScale * Time.deltaTime, speedScale * Time.deltaTime, speedScale * Time.deltaTime);
        }
        else
        {
            _linghtObject.SetActive(false);
        }
    }
}
