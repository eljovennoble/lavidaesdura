using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
public GameObject boton_ok;
public TextMeshProUGUI dialogo_text;

bool moverse_derecha,moverse_izquierda;
Animator my_animator;
SpriteRenderer my_sprite_renderer;

bool cama_cerca;

int interactuar_state;

    // Start is called before the first frame update
    void Start()
    {
        my_animator=GetComponent<Animator>();
        my_sprite_renderer=GetComponent<SpriteRenderer>();        
        interactuar_state=0;
        PlayerPrefs.SetInt("interruptor_accion", interactuar_state);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moverse_derecha&&interactuar_state==0){movimientoderecha();}
        if(moverse_izquierda&&interactuar_state==0){movimientizquierda();}
    }

  
  public void CerrarDialogo()
  {
 
    dialogo_text.text="";
   //PlayerPrefs.SetInt("interruptor_accion", 1);

  }

  public void MovDerecha()
  {
     interactuar_state=PlayerPrefs.GetInt("interruptor_accion",0);
     my_sprite_renderer.flipX=true;
     moverse_izquierda=false;
     moverse_derecha=true;
     my_animator.SetBool("movimiento",true);    
  }

    public void MovIzquierda()
  {
     interactuar_state=PlayerPrefs.GetInt("interruptor_accion",0);
     my_sprite_renderer.flipX=false;
     moverse_derecha=false;
     moverse_izquierda=true;
     my_animator.SetBool("movimiento",true);      
  } 

    void movimientoderecha(){
      this.transform.position=this.transform.position + new Vector3(0.05f,0,0);
      }
    void movimientizquierda(){this.transform.position=this.transform.position + new Vector3(-0.05f,0,0);}

     public void sin_movimiento()
     {
         this.transform.position=new Vector3(0,-0.5f,0) + Vector3.Scale(this.transform.position,new Vector3(1,0,1));
         moverse_derecha=false; 
         moverse_izquierda=false;
         my_animator.SetBool("movimiento",false); 
     }


     }





        
     /*
      public void dormir()
     {
      my_animator.SetBool("dormir",true); 
     }

     
private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="cama")
        {
         cama_cerca=true;
        } 
     }

 private void OnTriggerExit2D(Collider2D other) 
        
     {
        if(other.name=="cama")
        {
         cama_cerca=false;
        } 
     }

*/












