using UnityEngine;
using System.Collections;

public class resetScores : MonoBehaviour {

    // Use this for initialization
    public void resetScore()
    {
        PlayerPrefs.DeleteAll();
    }
}
