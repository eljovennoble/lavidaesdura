using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espejo : MonoBehaviour
{

public Sprite sprite_espejo,sprite_flip;
Sprite sprite_original;


   
    private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         sprite_original=this.GetComponent<SpriteRenderer>().sprite;
         if(other.GetComponent<SpriteRenderer>().flipX==false){this.GetComponent<SpriteRenderer>().sprite=sprite_espejo;}
         if(other.GetComponent<SpriteRenderer>().flipX==true){this.GetComponent<SpriteRenderer>().sprite=sprite_flip;} 
       
        } 
     }
    
     private void OnTriggerExit2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         this.GetComponent<SpriteRenderer>().sprite=sprite_original;
        } 
     }
}
