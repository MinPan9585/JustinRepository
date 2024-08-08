using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdfly : MonoBehaviour
{
    public GameObject bird;
    public GameObject warning;
    public Rigidbody2D birdbody;
    private float force = 0f;
    //private SpriteRenderer warn;
    // Start is called before the first frame update
    void Start()
    {
        //warn = warning.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        birdbody.MovePosition(birdbody.position + new Vector2(force, 0) * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("birdnow");
            force = 5f;
            //warning.SetActive(true);
            //new WaitForSeconds(3f);
            //warning.SetActive(false);
            //birdf(5);
        }
    }
    /*
    private void birdf(int force)
    {
        Vector2 move = new Vector2(0, force);
        birdbody.AddForce(move);
    }
    */
}
