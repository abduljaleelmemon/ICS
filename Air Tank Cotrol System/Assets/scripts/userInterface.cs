using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInterface : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuDown;
    public GameObject buttonDown;
    int start = 0;
    void Start()
    {

    }
    public void MoveUp() //for animation of menu
    {
        if (start == 0)
        {
            menuDown.GetComponent<Animator>().Play("ui"); //moving menu down after button is pressed
            buttonDown.GetComponent<Animator>().Play("updown"); //rotating animation ater button is pressed 
            start = 1;
        }
        else
        {
            start = 0;
            menuDown.GetComponent<Animator>().Play("uiDown"); // moving menu up 
            buttonDown.GetComponent<Animator>().Play("downup"); //rotating animation ater button is pressed 
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
