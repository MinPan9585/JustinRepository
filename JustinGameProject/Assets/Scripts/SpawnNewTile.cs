using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewTile : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public Transform bgTrans;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TriggerBox")
        {
            GameObject tile = Instantiate(tilePrefabs[Random.Range(0,2)], new Vector3(0,-19.9f,0), Quaternion.identity);
            tile.transform.SetParent(bgTrans);
        }
    }
}
