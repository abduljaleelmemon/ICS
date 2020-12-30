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
    public void ValueAssign() {
        status = true;
        setPointPressure = float.Parse(setPoint.GetComponent<Text>().text);
        InvokeRepeating("Increment", 2f, 2f);
    }
    void Increment() {
        frequency += Random.Range(0.5f, 1.5f);
        currentPressure += Random.Range(0.01f, 0.1f);
        pressure.text = currentPressure.ToString("n2") + " bar.";
        inputFrequency.text = frequency.ToString("n2") + " hz.";
        panelFrequency.text = "Motor Frequency: "+ frequency.ToString("n2") + " hz.";
        panelPressure.text = "Tank Pressure: " + currentPressure.ToString("n2") + " bar.";
        if (setPointPressure + Random.Range(0.01f, 0.1f)*2 < currentPressure)
        {
            CancelInvoke("Increment");
            InvokeRepeating("Decrement", 2f, 2f);
        }
    }
    public void RestartGame()
    {
        status = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // loads current scene
    }
    public void Pause(){
        status = false;
        CancelInvoke("Increment");
        CancelInvoke("Decrement");
    }
    void Decrement() {
        frequency -= Random.Range(0.5f, 1.5f);
        currentPressure -= Random.Range(0.01f, 0.1f);
        pressure.text = currentPressure.ToString("n2") + " bar.";
        inputFrequency.text = frequency.ToString("n2") + " hz.";
        panelFrequency.text = "Motor Frequency: " + frequency.ToString("n2") + " hz.";
        panelPressure.text = "Tank Pressure: " + currentPressure.ToString("n2") + " bar.";
        if (currentPressure < setPointPressure - Random.Range(0.01f, 0.1f)*2 )
        {
            CancelInvoke("Decrement");
            InvokeRepeating("Increment", 2f, 2f);
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
