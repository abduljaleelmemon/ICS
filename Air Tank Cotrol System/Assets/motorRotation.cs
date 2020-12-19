using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motorRotation : MonoBehaviour
{
    public float moveSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(Vector3.forward * 3 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, moveSpeed );
        //trasform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
