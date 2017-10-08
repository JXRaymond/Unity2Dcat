using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class highScores : MonoBehaviour
{

    private int score;
    private int highScore;
    public Text scoreText;
    public Text scoreText2;
    public Text scoreText3;
    public Text scoreText4;
    public Text scoreText5;
    public Text scoreText6;
    public Text scoreText7;
    public Text scoreText8;
    public Text scoreText9;
    public Text scoreText10;

    public Text nameText;
    public Text nameText2;
    public Text nameText3;
    public Text nameText4;
    public Text nameText5;
    public Text nameText6;
    public Text nameText7;
    public Text nameText8;
    public Text nameText9;
    public Text nameText10;

    static int score1;
    static int score2;
    static int score3;
    static int score4;
    static int score5;
    static int score6;
    static int score7;
    static int score8;
    static int score9;
    static int score10;
    int scoretemp;
    static string name1;
    static string name2;
    static string name3;
    static string name4;
    static string name5;
    static string name6;
    static string name7;
    static string name8;
    static string name9;
    static string name10;
    string nametemp;

    GameObject userName;

    void Start()
    {
        getScores();
        getNames();
        if (PlayerPrefs.GetInt("New Score Flag") == 1) //If the player has broken the lowest highscore
        {

            if (PlayerPrefs.HasKey("myScore"))
            {
                if (scoretemp > score1)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = score5;
                    score5 = score4;
                    score4 = score3;
                    score3 = score2;
                    score2 = score1;
                    score1 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = name5;
                    name5 = name4;
                    name4 = name3;
                    name3 = name2;
                    name2 = name1;
                    name1 = nametemp;
                }
                else if (scoretemp > score2)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = score5;
                    score5 = score4;
                    score4 = score3;
                    score3 = score2;
                    score2 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = name5;
                    name5 = name4;
                    name4 = name3;
                    name3 = name2;
                    name2 = nametemp;
                }
                else if (scoretemp > score3)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = score5;
                    score5 = score4;
                    score4 = score3;
                    score3 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = name5;
                    name5 = name4;
                    name4 = name3;
                    name3 = nametemp;
                }
                else if (scoretemp > score4)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = score5;
                    score5 = score4;
                    score4 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = name5;
                    name5 = name4;
                    name4 = nametemp;
                }
                else if (scoretemp > score5)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = score5;
                    score5 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = name5;
                    name5 = nametemp;
                }
                else if (scoretemp > score6)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = score6;
                    score6 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = name6;
                    name6 = nametemp;
                }
                else if (scoretemp > score7)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = score7;
                    score7 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = name7;
                    name7 = nametemp;
                }
                else if (scoretemp > score8)
                {
                    score10 = score9;
                    score9 = score8;
                    score8 = scoretemp;
                    name10 = name9;
                    name9 = name8;
                    name8 = nametemp;
                }
                else if (scoretemp > score9)
                {
                    score10 = score9;
                    score9 = scoretemp;
                    name10 = name9;
                    name9 = nametemp;
                }
                else if (scoretemp > score10)
                {
                    score10 = scoretemp;
                    name10 = nametemp;
                }
                scoreText.text = "Score:\t" + score1.ToString();
                scoreText2.text = "Score:\t" + score2.ToString();
                scoreText3.text = "Score:\t" + score3.ToString();
                scoreText4.text = "Score:\t" + score4.ToString();
                scoreText5.text = "Score:\t" + score5.ToString();
                scoreText6.text = "Score:\t" + score6.ToString();
                scoreText7.text = "Score:\t" + score7.ToString();
                scoreText8.text = "Score:\t" + score8.ToString();
                scoreText9.text = "Score:\t" + score9.ToString();
                scoreText10.text = "Score:\t" + score10.ToString();
                nameText.text = "Name:\t" + name1;
                nameText2.text = "Name:\t" + name2;
                nameText3.text = "Name:\t" + name3;
                nameText4.text = "Name:\t" + name4;
                nameText5.text = "Name:\t" + name5;
                nameText6.text = "Name:\t" + name6;
                nameText7.text = "Name:\t" + name7;
                nameText8.text = "Name:\t" + name8;
                nameText9.text = "Name:\t" + name9;
                nameText10.text = "Name:\t" + name10;
            }
            saveScores();
            saveNames();
            PlayerPrefs.SetInt("myScore", 0);
        }
        else
        {
            scoreText.text = "Score:\t" + score1.ToString();
            scoreText2.text = "Score:\t" + score2.ToString();
            scoreText3.text = "Score:\t" + score3.ToString();
            scoreText4.text = "Score:\t" + score4.ToString();
            scoreText5.text = "Score:\t" + score5.ToString();
            scoreText6.text = "Score:\t" + score6.ToString();
            scoreText7.text = "Score:\t" + score7.ToString();
            scoreText8.text = "Score:\t" + score8.ToString();
            scoreText9.text = "Score:\t" + score9.ToString();
            scoreText10.text = "Score:\t" + score10.ToString();
            nameText.text = "Name:\t" + name1;
            nameText2.text = "Name:\t" + name2;
            nameText3.text = "Name:\t" + name3;
            nameText4.text = "Name:\t" + name4;
            nameText5.text = "Name:\t" + name5;
            nameText6.text = "Name:\t" + name6;
            nameText7.text = "Name:\t" + name7;
            nameText8.text = "Name:\t" + name8;
            nameText9.text = "Name:\t" + name9;
            nameText10.text = "Name:\t" + name10;
        }

    }
    void saveScores()
    {
        PlayerPrefs.SetInt("HiScore1", score1);
        PlayerPrefs.SetInt("HiScore2", score2);
        PlayerPrefs.SetInt("HiScore3", score3);
        PlayerPrefs.SetInt("HiScore4", score4);
        PlayerPrefs.SetInt("HiScore5", score5);
        PlayerPrefs.SetInt("HiScore6", score6);
        PlayerPrefs.SetInt("HiScore7", score7);
        PlayerPrefs.SetInt("HiScore8", score8);
        PlayerPrefs.SetInt("HiScore9", score9);
        PlayerPrefs.SetInt("HiScore10", score10);
    }

    void saveNames()
    {
        PlayerPrefs.SetString("Name1", name1);
        PlayerPrefs.SetString("Name2", name2);
        PlayerPrefs.SetString("Name3", name3);
        PlayerPrefs.SetString("Name4", name4);
        PlayerPrefs.SetString("Name5", name5);
        PlayerPrefs.SetString("Name6", name6);
        PlayerPrefs.SetString("Name7", name7);
        PlayerPrefs.SetString("Name8", name8);
        PlayerPrefs.SetString("Name9", name9);
        PlayerPrefs.SetString("Name10", name10);
    }

    void getScores()
    {
        scoretemp = PlayerPrefs.GetInt("myScore");
        score1 = PlayerPrefs.GetInt("HiScore1");
        score2 = PlayerPrefs.GetInt("HiScore2");
        score3 = PlayerPrefs.GetInt("HiScore3");
        score4 = PlayerPrefs.GetInt("HiScore4");
        score5 = PlayerPrefs.GetInt("HiScore5");
        score6 = PlayerPrefs.GetInt("HiScore6");
        score7 = PlayerPrefs.GetInt("HiScore7");
        score8 = PlayerPrefs.GetInt("HiScore8");
        score9 = PlayerPrefs.GetInt("HiScore9");
        score10 = PlayerPrefs.GetInt("HiScore10");
    }


    void getNames()
    {
        nametemp = PlayerPrefs.GetString("myName");
        name1 = PlayerPrefs.GetString("Name1");
        name2 = PlayerPrefs.GetString("Name2");
        name3 = PlayerPrefs.GetString("Name3");
        name4 = PlayerPrefs.GetString("Name4");
        name5 = PlayerPrefs.GetString("Name5");
        name6 = PlayerPrefs.GetString("Name6");
        name7 = PlayerPrefs.GetString("Name7");
        name8 = PlayerPrefs.GetString("Name8");
        name9 = PlayerPrefs.GetString("Name9");
        name10 = PlayerPrefs.GetString("Name10");
    }
}
