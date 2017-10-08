using UnityEngine;
using System.Collections;

public class coinBox : MonoBehaviour {

    // Use this for initialization
    public GameObject coin;
    public GameObject used;
    public Transform Spawnpoint;

    public AudioClip boxBreak;
    void OnTriggerEnter2D()
    {
        AudioSource.PlayClipAtPoint(boxBreak, transform.position);
        Instantiate(coin, Spawnpoint.position, Spawnpoint.rotation);
        Instantiate(used, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
