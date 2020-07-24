using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public GameObject anotherBall;
    public float timer;
    public int spawnTime = 2;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            Instantiate(anotherBall,gameObject.transform);
            timer=0;
        }
    }
}
