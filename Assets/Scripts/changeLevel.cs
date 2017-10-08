using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changeLevel : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("level2");
        }
    }
}
