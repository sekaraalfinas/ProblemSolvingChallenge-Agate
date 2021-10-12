using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement2 : MonoBehaviour
{

    public float movementSpeed;
    public Rigidbody2D rb;
    Vector2 movement;

    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "cube")
        {
            gameManager.IncreaseScore();
            Destroy(collider.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

}
