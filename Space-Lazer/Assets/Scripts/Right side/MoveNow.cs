using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNow : MonoBehaviour
{
    public float buttonTime = 0.3f;
    float jumpTime;
    bool jumping;

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
        if (Input.GetKey(KeyCode.J))
        {
            Input.GetAxis("Horizontal");
            transform.Translate(Vector3.back * horizontalInput * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Input.GetAxis("Horizontal");
            transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);
        }





    }

}