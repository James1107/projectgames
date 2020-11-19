using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemove : MonoBehaviour
{
    public float speed1 = 1.2f;
    // Movement Speed (0 means don't move)
    public float speed = 0;

    // Switch Movement Direction every x seconds
    public float switchTime = 2;

    void Start()
    {
        // Initial Movement Direction
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        // Switch every few seconds
        InvokeRepeating("Switch", 0, switchTime);
    }

    void Switch()
    {
        GetComponent<Rigidbody2D>().velocity *= -1;
    }
    void Update()
    {
        obs2();
    }
    void obs2()
    {
        transform.Translate(-speed1 * Time.deltaTime, 0, 0);
    }


}
