using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    bool derecha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(derecha==false){this.transform.position=this.transform.position + new Vector3(-0.05f,0,0);}
        if(derecha==true) {this.transform.position=this.transform.position + new Vector3( 0.05f,0,0);}
    }

    public void setDerecha(bool direccion_derecha){derecha=direccion_derecha;}
}
