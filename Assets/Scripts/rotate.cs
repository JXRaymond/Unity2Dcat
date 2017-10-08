using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

    // Use this for initialization
    private int spinx = 0;
    private int spiny = 0;
    private int spinz = 7;
	// Update is called once per frame
	void Update () {
        transform.Rotate(spinx, spiny, spinz);
	}
}
