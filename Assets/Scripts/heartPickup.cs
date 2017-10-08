using UnityEngine;
using System.Collections;

public class heartPickup : MonoBehaviour {

    // Use this for initialization
    public AudioClip heartCollect;
	void Start () {
	
	}

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            livesManager.AddLife();
        AudioSource.PlayClipAtPoint(heartCollect, transform.position);
        Destroy(gameObject);
    }
}
