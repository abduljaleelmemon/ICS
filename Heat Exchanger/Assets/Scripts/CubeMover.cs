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
	   if(Input.GetKey(keyUp)) { //after pressing on left arrow this condition will execute 
		   if (currentY<360)
           {
               Debug.Log("Pressed left click.");
               transform.Rotate(d,0 ,0); // rotation of an object
               GameObject.FindGameObjectWithTag("MPin").GetComponent<Manometer>().RotateRight(gameObject,-2.3f); // will access rotateright function from manometer script
               GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().OnSteamIn(gameObject, -1.45f); // will access onsteamin function from steamin script
		   }
	   }
	   if(Input.GetKey(keyDown)){
           if (currentY > 359.1474)
           {
               Debug.Log("Pressed right click.");
               transform.Rotate(-d,0 ,0); // rotation in opposite directiion
               GameObject.FindGameObjectWithTag("MPin").GetComponent<Manometer>().RotateLeft(gameObject, 2.3f); // will access rotateright function from manometer script
               GameObject.FindGameObjectWithTag("outerTank").GetComponent<steamIn>().OnSteamIn(gameObject, 1.45f); // will access onsteamin function from steamin script
		   }
	   }
	}
}
