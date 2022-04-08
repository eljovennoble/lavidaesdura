using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour
{
Rigidbody my_rigibody;
public float velocidad =2;


  
    void Start()
    {
        my_rigibody = GetComponent<Rigidbody>();
     
    }

    void Update()
    {
        Vector3 tilt= Input.acceleration;
        tilt=Quaternion.Euler(90,0,0)*tilt;
        my_rigibody.AddForce(tilt*velocidad);
    }
}
