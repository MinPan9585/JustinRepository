using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    float horizontalSpeed;
    public float verticalSpeed;
    float speedMultiplier = 2f;

    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Resources.Load("Bullet"), transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(horizontalSpeed * speedMultiplier, verticalSpeed) * Time.fixedDeltaTime * speedMultiplier);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //game over
            Destroy(gameObject);
            //Time.timeScale = 0;
        }
    }
}
