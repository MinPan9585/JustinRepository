using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    void Update()
    {
        rb.velocity = new Vector2(0, -5);
    }
}
