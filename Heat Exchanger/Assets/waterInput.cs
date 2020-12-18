using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class waterInput : MonoBehaviour
{
    public GameObject initialTemprature;
    public GameObject finalTemprature;
    public TextMeshPro tempC;
    private float ExpectedWaterOutTemp = 0, waterOut = 0, waterIn = 0;
    private float TDC = 1.5435f, steamTemp = 0, temp=0;
    private float a = 100, b = 200, c = 1150, d = 600;
    private bool x = false;
    public void Running()
    {
        if (x == false) { 
            ExpectedWaterOutTemp = float.Parse(finalTemprature.GetComponent<Text>().text);
            waterOut = float.Parse(initialTemprature.GetComponent<Text>().text);
            x = true;
        }
        InvokeRepeating("increment", 2f, 2f);
    }
    public void Stopping() {
        CancelInvoke("increment");
    }
	void OnGUI()
	{
        GUIStyle style = new GUIStyle();
        style.fontStyle = FontStyle.Bold;
        style.fontSize = 20;
        style.richText = true;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(a,b,c,d),"Water's Expected Temperature is "+((int)ExpectedWaterOutTemp).ToString()+"°C", style);
		GUI.Label(new Rect(a,b+25,c,d),"Steam's Input Pressure is "+((int)steamTemp).ToString()+" pa", style);
        GUI.Label(new Rect(a, b + 50, c, d), "Water's Final Temperature is " + ((int)waterOut).ToString() + "°C", style);
	}
    // Start is called before the first frame update
    void Start()
    {
		waterOut=waterIn;
		InvokeRepeating ("increment", 2f, 2f);
        // Set the text
        tempC.text = "0 °C";
    }

    // Update is called once per frame
    void Update()
    {	
		TempChange();
        tempC.text = waterOut.ToString() + " °C";
		if((int)waterOut==(int)ExpectedWaterOutTemp){
			 CancelInvoke("increment");
		}
		
    }
	void increment(){
		if(waterOut<temp)
            waterOut += 1;
	}
	void TempChange(){
		steamTemp=GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().GetSteamTemp();
		if(steamTemp>0){
            temp=ExpectedWaterOutTemp-waterIn;
            temp=temp/TDC;temp=steamTemp-temp;
        }
	}
}
