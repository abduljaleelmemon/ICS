﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamIn : MonoBehaviour
{
    // Start is called before the first frame update
    private float steamInput=0;
	private float a=100;
	private float b=220;
	private float c=250;
	private float d=250;
	void OnGUI()
	{
		//GUI.Label(new Rect(a,b,c,d),"Steam's Input Temperature is "+((int)steamInput).ToString());
	}
	public void OnSteamIn(GameObject g,float d)
	{
		if(steamInput>=0)
			steamInput+=d;
	}
	public float GetSteamTemp(){
		return steamInput;
	} 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}