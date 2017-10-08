using UnityEngine;
using System.Collections;

public class eventEnemy : MonoBehaviour {

    // Use this for initialization
    public GameObject coin;
   // public GameObject used;
    public Transform Spawnpoint;
    public AudioClip rawr;

    float volume = 2f;

    void OnTriggerEnter2D()
    {
        AudioSource.PlayClipAtPoint(rawr, transform.position, volume);
        Instantiate(coin, Spawnpoint.position, Spawnpoint.rotation);
        Destroy(gameObject);
    }
}
