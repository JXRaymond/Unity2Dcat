using UnityEngine;
using System.Collections;

public class rotateCoin : MonoBehaviour
{

    // Use this for initialization
    private int spinx = 0;
    private int spiny = 5;
    private int spinz = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinx, spiny, spinz);
    }
}