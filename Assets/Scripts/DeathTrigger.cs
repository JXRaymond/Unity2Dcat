﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    
    void Start() {
        
        
    }

    // Update is called once per frame
    void Update() {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
            SceneManager.LoadScene("game");

    }
}
