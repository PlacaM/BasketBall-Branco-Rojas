using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public int score = 10;
    public  TextMeshProUGUI scoreText;
    public int highScore;
    public TextMeshProUGUI highScoreText;
    public  float timer = 0.1f;
    public int time;
    public TextMeshProUGUI timeText;

    



    public void AddScore(int NewScore)
    {
        score += NewScore;
        scoreText.SetText(score.ToString());
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Net"))
        {
            
            AddScore(10);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text = time.ToString();

        

    }
}
