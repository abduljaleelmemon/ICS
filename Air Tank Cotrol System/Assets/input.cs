using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public GameObject setPoint;
    public TextMeshPro freq;
    public Text panelfreq;
    public Text panelpressure;
    public TextMeshPro pressure;
    private float setpoint_p, Cpressure;
    public static float frequency;
    public static bool status  = false;
    // Start is called before the first frame update
    void Start()
    {
          
    }
    public void valueAssign() {
        status = true;
        setpoint_p = float.Parse(setPoint.GetComponent<Text>().text);
        InvokeRepeating("increment", 2f, 2f);
    }
    void increment() {
        frequency += Random.Range(0.5f, 1.5f);
        Cpressure += Random.Range(0.01f, 0.1f);
        pressure.text = Cpressure.ToString("n2") + " bar.";
        freq.text = frequency.ToString("n2") + " hz.";
        panelfreq.text = "Motor Frequency: "+ frequency.ToString("n2") + " hz.";
        panelpressure.text = "Tank Pressure: " + Cpressure.ToString("n2") + " bar.";
        if (setpoint_p + Random.Range(0.01f, 0.1f)*2 < Cpressure)
        {
            CancelInvoke("increment");
            InvokeRepeating("decrement", 2f, 2f);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // loads current scene
    }
    public void pause(){
        status = false;
        CancelInvoke("increment");
        CancelInvoke("decrement");
    }
    void decrement() {
        frequency -= Random.Range(0.5f, 1.5f);
        Cpressure -= Random.Range(0.01f, 0.1f);
        pressure.text = Cpressure.ToString("n2") + " bar.";
        freq.text = frequency.ToString("n2") + " hz.";
        panelfreq.text = "Motor Frequency: " + frequency.ToString("n2") + " hz.";
        panelpressure.text = "Tank Pressure: " + Cpressure.ToString("n2") + " bar.";
        if (Cpressure < setpoint_p - Random.Range(0.01f, 0.1f)*2 )
        {
            CancelInvoke("decrement");
            InvokeRepeating("increment", 2f, 2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //if (status == true) { 
        //}
        //else { }
    }
}
