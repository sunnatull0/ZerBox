using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public RocketController rocket;
    public Text scoreText;
    public Text highScoretext;
    private float highscore;
    private float score = 0f;
    public float scorespeed;

    private void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");
    }

    void Update()
    {
        score += Time.deltaTime * scorespeed;
        scoreText.text = "SCORE: " + (int)score;
        highScoretext.text = "RECORD: " + (int)highscore;
        if(score > highscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }

        if(score > 1000f)
        {
            rocket.waitTime = 0.2f;
            rocket.waittime2 = 0.9f;
        }
    }
}
