using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject linghtObject;

    private float speed = 10f;
    private float minValueTime = 6f;
    private float EndPositionX = -15f;

    void Update()
    {
        if (gameManager.time >= minValueTime && EndPositionX < gameObject.transform.position.x)
        {
            linghtObject.SetActive(true);

            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else
        {
            linghtObject.SetActive(false);
        }
    }
}
