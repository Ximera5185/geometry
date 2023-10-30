using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time = 0;

    private void Update()
    {
        time += Time.deltaTime;
    }
}
