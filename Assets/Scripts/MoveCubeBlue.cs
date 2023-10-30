using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCubeBlue : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject linghtObject;

    private float speedMoveX = 5f;
    private float speedMoveY = 0.2f;
    private float speedrRotate = 25f;
    private float speedScale = 0.9f;

    private float minValueTime = 13f;
    private float maxValueTime = 20f;

    private void Update()
    {
        if (gameManager.time > minValueTime && gameManager.time < maxValueTime)
        {
            linghtObject.SetActive(true);

            transform.Translate(speedMoveX * Time.deltaTime, speedMoveY * Time.deltaTime, 0);

            transform.Rotate(0, -speedrRotate * Time.deltaTime, 0);

            transform.localScale += new Vector3(speedScale * Time.deltaTime, speedScale * Time.deltaTime, speedScale * Time.deltaTime);
        }
        else
        {
            linghtObject.SetActive(false);
        }
    }
}
