using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manometer : MonoBehaviour
{
	void Update(){
		
	}
	public float CurrentY = 0;
	public void RotateRight(GameObject g,float d){
		CurrentY = 360-transform.rotation.y; 
		if(CurrentY>359.4961 )
		 transform.Rotate(0 ,d,0, Space.Self); 
	}
	public void RotateLeft(GameObject g,float d){
		CurrentY = 360-transform.rotation.y;
		if(CurrentY<360.69 )
		 transform.Rotate(0 ,d,0, Space.Self);
	} 
}
