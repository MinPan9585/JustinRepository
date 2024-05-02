using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    float horizontalSpeed;
    public float verticalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + new Vector2(horizontalSpeed, verticalSpeed) * Time.fixedDeltaTime);
    }
}
