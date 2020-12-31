using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
	[SerializeField]
	Vector3 v3Force = new Vector3(0.1f,0,0);
	[SerializeField]
	Vector3 v3Force1 = new Vector3(0,0,0.1f);
	[SerializeField]
	Vector3 v3Force2 = new Vector3(0,0.1f,0);
   [SerializeField]
	KeyCode keyUp;
   [SerializeField]
	KeyCode keyDown;
	[SerializeField]
	KeyCode keyLeft;
   [SerializeField]
	KeyCode keyRight;
   [SerializeField]
	KeyCode keyForward;
   [SerializeField]
	KeyCode keyBackward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {	
		if (Input.GetKey(keyUp))
			//GetComponent<Rigidbody>().velocity += v3Force;
			transform.position+=v3Force2;
		if (Input.GetKey(keyDown))
			//GetComponent<Rigidbody>().velocity -= v3Force;
			transform.position-=v3Force2;
		if (Input.GetKey(keyLeft))
			//GetComponent<Rigidbody>().velocity += v3Force;
			transform.position+=v3Force1;
		if (Input.GetKey(keyRight))
			//GetComponent<Rigidbody>().velocity -= v3Force;
			transform.position-=v3Force1;
			if (Input.GetKey(keyForward))
			//GetComponent<Rigidbody>().velocity += v3Force;
			transform.position+=v3Force;
		if (Input.GetKey(keyBackward))
			//GetComponent<Rigidbody>().velocity -= v3Force;
			transform.position-=v3Force;
    }
}
