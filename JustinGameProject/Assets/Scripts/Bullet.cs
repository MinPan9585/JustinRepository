using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject smokepuff;
    private float horispeed;
    void Update()
    {

        if (transform.localRotation.eulerAngles.z <= 180f)
        {
            horispeed = transform.localRotation.eulerAngles.z;
        }
        else
        {
            horispeed = transform.localRotation.eulerAngles.z - 360f;
        }
        
        rb.velocity = new Vector2(horispeed/20, -5);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Fly")
        {
            
            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            Debug.Log(PlayerPrefs.GetInt("score"));
            Destroy(col.gameObject);
            
        }
        Destroy(gameObject);
        Instantiate(smokepuff, transform.position, Quaternion.identity);
    }
}
