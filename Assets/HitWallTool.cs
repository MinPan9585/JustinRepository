using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWallTool : MonoBehaviour
{
    public GameObject one;
    public GameObject three;
    private void OnTriggerEnter(Collider other)
    {
        //if (this.gameObject.GetComponent<Rigidbody>().velocity.magnitude >= 0.01f)
        //{
            one.SetActive(false);
            one.GetComponent<Renderer>().enabled = false;
            three.SetActive(true);
        //}
    }
}
