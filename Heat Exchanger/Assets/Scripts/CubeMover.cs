using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	
public class CubeMover : MonoBehaviour
{	
	
	public float currentY = 0;
	private float d = -1;
	[SerializeField]
	KeyCode keyUp;
   [SerializeField]
	KeyCode keyDown;
	void Update(){
	currentY = 360-transform.rotation.x;
	   if(Input.GetKey(keyUp)) {
		   if (currentY<360){
		   Debug.Log("Pressed left click.");
			transform.Rotate(d,0 ,0);
			GameObject.FindGameObjectWithTag("MPin").GetComponent<Manometer>().RotateRight(gameObject,-2.3f);
			GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().OnSteamIn(gameObject,-1.45f);
		   }
	   }
	   if(Input.GetKey(keyDown)){
           if (currentY > 359.1474)
           {
		    Debug.Log("Pressed right click.");
			transform.Rotate(-d,0 ,0);
			GameObject.FindGameObjectWithTag("MPin").GetComponent<Manometer>().RotateLeft(gameObject,2.3f);
			GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().OnSteamIn(gameObject,1.45f);
		   }
	   }
	}
}
