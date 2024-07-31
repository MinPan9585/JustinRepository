using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    void Update()
    {
        rb.velocity = new Vector2(0, -5);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            Debug.Log(PlayerPrefs.GetInt("score"));
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
