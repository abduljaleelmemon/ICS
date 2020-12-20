using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpWater : MonoBehaviour
{
	[SerializeField]
	Vector3 v3Force = new Vector3(0.1f,0,0);
	[SerializeField]
	Vector3 v3Force1 = new Vector3(0,0.01f,0);
	[SerializeField]
	Vector3 v3Force2 = new Vector3(0,0.01f,0);
    // Start is called before the first frame update
	bool on=true;
	bool invokeStarted=false;
	int x=1;
	void Start()
    {
         //Start the coroutine we define below named ExampleCoroutine.StartCoroutine(ExampleCoroutine());
    }
	IEnumerator ExampleCoroutine()
    {
		
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
		//tempC.text = "1 HP pump";
        //yield on a new YieldInstruction that waits for 5 seconds.
		//GetComponent<Rigidbody>().velocity += v3Force;
			transform.position+=v3Force2;
			yield return new WaitForSeconds(0.1f);
			//GetComponent<Rigidbody>().velocity -= v3Force;
			transform.position-=v3Force2;
			if(Time.time>60){
				on=false;
			}
			
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    // Update is called once per frame
    void FixedUpdate()
    {	
		if(on)
		{
			StartCoroutine(ExampleCoroutine());
			if(invokeStarted==false)
			{
				GameObject.FindGameObjectWithTag("coagTank").GetComponent<WaterInput1>().StartInv();
				invokeStarted=true;
			}
		}
		else{
			GameObject.FindGameObjectWithTag("coagTank").GetComponent<WaterInput1>().cancel();
			invokeStarted=false;
		}
    }
}
