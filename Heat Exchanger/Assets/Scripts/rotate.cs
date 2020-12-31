using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class rotate : MonoBehaviour
{
 
    public float rotateSpeed = 180f;
 
 
    // Use this for initialization
    void Start () {
 
    }
 
    void Update () {
 
    }
 
    public void OnClickLeft () {
       
        transform.Rotate(Vector3.forward*rotateSpeed*Time.deltaTime);
 
    }
   
}