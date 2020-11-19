using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    // Movement speed
    public float speed = 2;

    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Flap
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    // Called when a collision occurs (ie. Bird hits the ground, or a object)
    void OnCollisionEnter2D(Collision2D coll)
    {
        // Restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
