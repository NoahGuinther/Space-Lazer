using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOf : MonoBehaviour
{
    private float topBound = 120;
   void Update()
   {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
   }
}
