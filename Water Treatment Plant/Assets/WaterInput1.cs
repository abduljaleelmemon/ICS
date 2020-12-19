using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class WaterInput1 : MonoBehaviour
{	
	float waterFlowRate=0.9333f;
	float Water=0f;
	private float a=100;
	private float b=200;
	private float c=250;
	private float d=250;
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
	/**IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
		//tempC.text = "1 HP pump";
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
		
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }**/
	public void cancel(){
		 CancelInvoke("func");
	}
	public void func(){
		Water+=waterFlowRate;
		//StartCoroutine(ExampleCoroutine());
	}
}
