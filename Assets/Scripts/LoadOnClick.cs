using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {

    // Use this for initialization
    public void LoadScene(int level)
    {
        PlayerPrefs.SetInt("PlayerLives", 3);
        PlayerPrefs.SetInt("PlayerScore", 0);
        SceneManager.LoadScene(level);
    }
}
