using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntradaCasa : MonoBehaviour
{
    
    public GameObject personaje_principal;
    bool personaje_cerca;
    public GameObject boton_ok,boton_derecha,boton_izquierda;


private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         personaje_cerca=true;
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         boton_ok.GetComponent<Button>().onClick.AddListener(entrar_casa);
        } 
     }

 private void OnTriggerExit2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         personaje_cerca=false;    
        } 
     }
     
 public void entrar_casa()
    {
     personaje_principal.GetComponent<Transform>().position=new Vector3(10.35f,-0.5f,0);
     personaje_principal.GetComponent<SpriteRenderer>().flipX=false;
    }



}
