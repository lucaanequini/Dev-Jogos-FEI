using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ia : MonoBehaviour
{
    public float speed = 3.0f;
    public float boundX = 4.5f;
    private GameObject rb2d;
    private GameObject ball;
    private float maxSpeed = 1.5f; // Velocidade máxima permitida

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GameObject.FindGameObjectWithTag("Player2");
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball == null)
        {
            Debug.LogError("Ball not found");
            return;
        }

        float newX = Mathf.Clamp(ball.transform.position.x, -boundX, boundX);
        float newY = transform.position.y;

        Vector3 newPos = new Vector3(newX, newY, transform.position.z);

        float step = Mathf.Min(speed / 2 * Time.deltaTime, maxSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, newPos, step);
    }
}
