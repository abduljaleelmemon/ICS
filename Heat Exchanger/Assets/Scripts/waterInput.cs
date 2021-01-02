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
    private float expectedWaterOutTemp = 0, waterOut = 0, waterIn = 0;
    private float TDC = 1.5435f, steamTemp = 0, temp=0;
    private float a = 100, b = 200, c = 1150, d = 600;
    private bool check = false;
    public void Running()
    {
        if (check == false) { 
            expectedWaterOutTemp = float.Parse(finalTemprature.GetComponent<Text>().text);
            waterOut = float.Parse(initialTemprature.GetComponent<Text>().text);
            check = true;
        }
        InvokeRepeating("Increment", 2f, 2f);
    }
    public void Stopping() { // stopping increment e.g pausing the screen
        CancelInvoke("Increment");
    }
	void OnGUI() // GUI TEXT Showing different information
	{
        GUIStyle style = new GUIStyle();
        style.fontStyle = FontStyle.Bold;
        style.fontSize = 20;
        style.richText = true;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.MiddleCenter;
		GUI.Label(new Rect(a,b,c,d),"Water's Expected Temperature is "+((int)expectedWaterOutTemp).ToString()+"°C", style);
		GUI.Label(new Rect(a,b+25,c,d),"Steam's Input Pressure is "+((int)steamTemp).ToString()+" pa", style);
        GUI.Label(new Rect(a, b + 50, c, d), "Water's Final Temperature is " + ((int)waterOut).ToString() + "°C", style);
	}
    // Start is called before the first frame update
    void Start()
    {
		waterOut=waterIn;
		InvokeRepeating ("Increment", 2f, 2f);
        // Set the text
        tempC.text = "0 °C";
    }

    // Update is called once per frame
    void Update()
    {	
		TempChange();
        tempC.text = waterOut.ToString() + " °C";
		if((int)waterOut==(int)expectedWaterOutTemp){
			 CancelInvoke("Increment");
		}
		
    }
	void Increment(){
		if(waterOut<temp)
            waterOut += 1;
	}
	void TempChange(){
		steamTemp=GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().GetSteamTemp();
		if(steamTemp>0){
            temp=expectedWaterOutTemp-waterIn;
            temp=temp/TDC;
            temp=steamTemp-temp;
        }
	}
}
