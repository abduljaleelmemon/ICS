using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class input : MonoBehaviour
{
    public GameObject setPoint;
    public TextMeshPro freq;
    public TextMeshPro pressure;
    private float setpoint_f, frequency;
    public static bool status  = false;
    // Start is called before the first frame update
    void Start()
    {
          
    }
    public void valueAssign() {
        status = true;
        setpoint_f = float.Parse(setPoint.GetComponent<Text>().text);
        pressure.text = setpoint_f.ToString() + " bar.";
        InvokeRepeating("increment", 2f, 2f);
    }
    void increment() {
        frequency += Random.Range(0.5f, 1.5f);
        freq.text = frequency.ToString("n2") + " hz.";
    }
    // Update is called once per frame
    void Update()
    {
        //if (status == true) { 
        //}
        //else { }
    }
}
