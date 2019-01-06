﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour {
    public int picks;
    public bool alive;
    public Text countText;

    // Use this for initialization
    void Start () {
        alive = true;
        picks = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (!alive)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick"))
        {
            other.gameObject.SetActive(false);
            picks += 1;
            SetCountText();
            GameObject.FindGameObjectWithTag("GameController").SendMessage("JudgeWin");
        }
    }
    void SetCountText()
    {
        countText.text = "Player Score: " + picks.ToString();

    }
}
