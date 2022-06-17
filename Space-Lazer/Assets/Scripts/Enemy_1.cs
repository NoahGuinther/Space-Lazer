using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    public int life = 0;
    //public float speed = 20;
    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Enemy_1");
        //If the object that triggered this collision is tagged "bullet"
        if (other.gameObject.CompareTag ( "bullet"))
        {
            life = life + 1;
            if (life == 50)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}