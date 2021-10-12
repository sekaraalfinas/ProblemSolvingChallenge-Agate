using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(this.StartBall()); 
    }

    public IEnumerator StartBall(bool isStarting = true)
    {
        yield return new WaitForSeconds(2);
        if (isStarting)
            this.MoveBall(new Vector2(1, 1));
    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.movementSpeed;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * speed;
    }

}
