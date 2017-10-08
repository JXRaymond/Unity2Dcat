using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class livesManager : MonoBehaviour {

    // Use this for initialization
    public static int lives;
    //public static string scoreName;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        lives = PlayerPrefs.GetInt("PlayerLives", lives);
    }

    void Update()
    {
        if (lives < 1)
            SceneManager.LoadScene("gameOver");

        text.text = "" + lives;
    }

    public static void lostLife()
    {
        lives -= 1;
        PlayerPrefs.SetInt("PlayerLives", lives);
    }
    public static void AddLife()
    {
        lives += 1;
        PlayerPrefs.SetInt("PlayerLives", lives);
    }
}
