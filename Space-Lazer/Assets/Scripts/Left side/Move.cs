using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Start is called before the first frame update  
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
        {
            Input.GetAxis("Horizontal");
            transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
        }
          


    }
}