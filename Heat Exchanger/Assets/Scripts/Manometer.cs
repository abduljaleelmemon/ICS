using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manometer : MonoBehaviour
{
	void Update(){
		
	}
	public float currentY = 0;
	public void RotateRight(GameObject g,float d){ //will rotate the manometer pin as they will be called in cubemover file
		currentY = 360-transform.rotation.y;
        if (currentY > 359.4961) {
            transform.Rotate(0, d, 0, Space.Self);
        }
		  
	}
	public void RotateLeft(GameObject g,float d){ //will rotate the manometer pin in opposite direction as they will be called in cubemover file
		currentY = 360-transform.rotation.y;
        if (currentY < 360.69) { 
            transform.Rotate(0, d, 0, Space.Self); 
        } 
	} 
}
