using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarNPC : MonoBehaviour
{
    // Start is called before the first frame update
    

  private void OnTriggerEnter2D(Collider2D other) {
     
   if(other.name=="npc_01(Clone)")
        {
            
       Destroy(other.gameObject);
        } 

  }
 
}
