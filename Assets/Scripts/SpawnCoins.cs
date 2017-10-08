using UnityEngine;
using System.Collections;

public class SpawnCoins : MonoBehaviour {

    public Transform[] coinSpawns;
    public GameObject coin;

	// Use this for initialization
	void Start () {
        Spawn();
	
	}

    // Update is called once per frame
    void Spawn ()
    {
	    for (int i = 0; i <coinSpawns.Length; i++)

        {
            int coinflip = Random.Range(0, 2);
            if (coinflip > 0)
                Instantiate(coin, coinSpawns[i].position, Quaternion.identity);
        }
	}
}
