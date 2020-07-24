using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCorutina : MonoBehaviour
{
    public GameObject player;
    public GameObject anotherBall;
    public int spawnTime = 2;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerBall());
        transform.LookAt(player.transform);
    }
    IEnumerator SpawnerBall()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(anotherBall,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
