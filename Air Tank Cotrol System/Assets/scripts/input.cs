using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    public GameObject setPoint;
    public TextMeshPro inputFrequency;
    public Text panelFrequency;
    public Text panelPressure;
    public TextMeshPro pressure;
    private float setPointPressure, currentPressure;
    public static float frequency;
    public static bool status  = false;
    // Start is called before the first frame update
    void Start()
    {
          
    }
    public void ValueAssign() { //assigning value to variable after button is pressed 
        status = true;
        setPointPressure = float.Parse(setPoint.GetComponent<Text>().text);
        InvokeRepeating("Increment", 2f, 2f); // calling increment function after some time e.g slower increment when data shown
    }
    void Increment() { // increment in pressure, frequency and assigning value to be shown on ui
        frequency += Random.Range(0.5f, 1.5f);
        currentPressure += Random.Range(0.01f, 0.1f);
        pressure.text = currentPressure.ToString("n2") + " bar.";
        inputFrequency.text = frequency.ToString("n2") + " hz.";
        panelFrequency.text = "Motor Frequency: "+ frequency.ToString("n2") + " hz.";
        panelPressure.text = "Tank Pressure: " + currentPressure.ToString("n2") + " bar.";
        if (setPointPressure + Random.Range(0.01f, 0.1f)*2 < currentPressure) // check or stopping increment and startig decrement
        {
            CancelInvoke("Increment");
            InvokeRepeating("Decrement", 2f, 2f);
        }
    }
    public void RestartGame() // will restart after the button is pressed this function will be called 
    {
        status = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // loads current scene
    }
    public void Pause(){ // pausig the screeen after button is pressed 
        status = false;
        CancelInvoke("Increment");
        CancelInvoke("Decrement");
    }
    void Decrement() { //decrement in pressure, frequency and assigning value to be shown on ui 
        frequency -= Random.Range(0.5f, 1.5f);
        currentPressure -= Random.Range(0.01f, 0.1f);
        pressure.text = currentPressure.ToString("n2") + " bar.";
        inputFrequency.text = frequency.ToString("n2") + " hz.";
        panelFrequency.text = "Motor Frequency: " + frequency.ToString("n2") + " hz.";
        panelPressure.text = "Tank Pressure: " + currentPressure.ToString("n2") + " bar.";
        if (currentPressure < setPointPressure - Random.Range(0.01f, 0.1f) * 2) // check or starting increment and stopping decrement
        {
            CancelInvoke("Decrement");
            InvokeRepeating("Increment", 2f, 2f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
