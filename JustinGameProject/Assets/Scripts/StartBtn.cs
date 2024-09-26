using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBtn : MonoBehaviour
{
    public GameObject startPage;
    float timer = 0;
    void Start()
    {
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        startPage.SetActive(false);
    }

    //private void Update()
    //{
    //    timer += Time.unscaledDeltaTime;
    //    if (timer > 5)
    //    {
    //        Time.timeScale = 1;
    //        startPage.SetActive(false);
    //    }
    //}
}
