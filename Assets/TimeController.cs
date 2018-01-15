using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeController : MonoBehaviour {

    public Text timerText;

    private DateTime start;
    // Use this for initialization
    void Start () {
        start = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
        timerText.text = Convert.ToInt32((DateTime.Now - start).TotalSeconds).ToString();
    }


}
