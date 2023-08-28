using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windturbine : MonoBehaviour
{
    private float angle;
    [Range(5f, 125f)] public float speed = 55f;
    public bool randomSpeed = true;

  
    void Start()
    {
        angle = Random.Range(0.0f, 120.0f);

        if (!randomSpeed) return;
        speed = Random.Range(75.0f, 86.0f);
    }

    void Update()
    {
        //transform.Rotate(-transform.forward, Time.deltaTime * speed);
        transform.localEulerAngles = new Vector3(0.0f, 0.0f, angle);
        angle += Time.deltaTime * speed;
    }
}
