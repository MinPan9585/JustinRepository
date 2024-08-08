using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyfly : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = rb.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {

        //rb.MovePosition(pos + newposgen() * Time.fixedDeltaTime);
        //Debug.Log("moved");
        transform.localPosition = newposgen();
    }
    private Vector2 newposgen()
    {
        int rx = Random.Range(0, 2);
        int ry = Random.Range(0, 2);
        if (Random.Range(0, 1) == 1)
        {
            rx = -rx;
        }
        if (Random.Range(0, 1) == 1)
        {
            ry = -ry;
        }
        //Debug.Log(new Vector2(rx, ry));
        return new Vector2(rx, ry);
    }

}
