using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorRotation : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(Vector3.forward * 3 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (input.status){
            transform.Rotate(Vector3.forward, input.frequency );
        }
        //trasform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
