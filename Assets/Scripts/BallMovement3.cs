using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement3 : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * movementSpeed, direction.y * movementSpeed);
        }

        else
        {
            rb.velocity = Vector2.zero;
        }

    }
}
