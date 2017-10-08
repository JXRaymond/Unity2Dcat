using UnityEngine;
using System.Collections;

public class coinPickUp : MonoBehaviour {

    // Use this for initialization

    public int pointsToAdd;

    public AudioClip coincollect;

	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            scoreManager.AddPoints(pointsToAdd);
        AudioSource.PlayClipAtPoint(coincollect, transform.position);
            Destroy(gameObject);
    }
}
