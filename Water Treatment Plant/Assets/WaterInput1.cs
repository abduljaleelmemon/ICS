using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class WaterInput1 : MonoBehaviour
{	
	float waterFlowRate=0.9333f;
	float Water=0f;
	float maxWaterInTAnk=56f;
	float waterPercentForbar=0f;
	private float a=100;
	private float b=200;
	private float c=250;
	private float d=250;
	public Slider waterLevel; 
    //public TextMeshPro tempC;
	void OnGUI()
	{
		GUI.Label(new Rect(a,b,c,d),"Water "+((int)Water)	.ToString()+" L");
		//GUI.Label(new Rect(a,b+20,c,d),"Steam's Input Temperature is "+((int)steamTemp).ToString());
		//GUI.Label(new Rect(a,b+40,c,d),"Water's Final Temperature is "+((int)waterOut).ToString());
	}
    // Start is called before the first frame update
    void Start()
    {	
		//waterLevel.value=0;
		 //StartInv();
         //Start the coroutine we define below named ExampleCoroutine.
        //func();
    }
	public void StartInv()
    {	
		InvokeRepeating ("func", 1f, 1f);
         //Start the coroutine we define below named ExampleCoroutine.
        //func();
    }
	public void cancel(){
		 CancelInvoke("func");
	}
	public void func(){
		Water+=waterFlowRate;
		waterPercentForbar=(int)(Water/maxWaterInTAnk);
		//Debug.Log(waterPercentForbar);
		//waterLevel.value=waterPercentForbar;
		//StartCoroutine(ExampleCoroutine());
	}
}
