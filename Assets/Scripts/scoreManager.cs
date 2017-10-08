using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour {

    public static int score;
    public static string scoreName;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        score = PlayerPrefs.GetInt("PlayerScore", score);
    }
    
    void Update()
    {
        if (score < 0)
            score = 0;

        text.text = "" + score;
    }

    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;
        PlayerPrefs.SetInt("PlayerScore", score);
    }
    public static int getScore()
    {
        return score;
    }
    public static void saveScores(string playerName)
    {
        scoreName = playerName;
        PlayerPrefs.SetInt("myScore", score);
        PlayerPrefs.SetString("myName", scoreName);
    }

    public static void Reset()
    {
        score = 0;
    }
}
