﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uimanage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menudown;
    public GameObject buttonDown;
    int start = 0;
    void Start()
    {
        
    }
    public void MoveUp() {
        if (start == 0)
        {
            menudown.GetComponent<Animator>().Play("ui");
            buttonDown.GetComponent<Animator>().Play("updown");
            start = 1;
        }
        else {
            start = 0;
            menudown.GetComponent<Animator>().Play("uiDown");
            buttonDown.GetComponent<Animator>().Play("downup");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}