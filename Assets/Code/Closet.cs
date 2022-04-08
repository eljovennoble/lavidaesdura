using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Closet : MonoBehaviour
{
    public GameObject personaje_principal;   

    public List<GameObject> ropa_closet_lista;
    public List<Sprite> ropa_closet_sprite_lista;

    int ropa_actual; 

    bool personaje_cerca;

    public GameObject grupo_closet;
    public GameObject boton_ok,boton_derecha,boton_izquierda;
    public TextMeshProUGUI dialogo_text;
    List<Vector3> posicion_ropa_original;
  

    public void abrir_closet()
    {
     dialogo_text.text= "Necesito encontrar algo que ponerme";   
     Debug.Log("abrir closet");
     PlayerPrefs.SetInt("interruptor_accion", 1);
     grupo_closet.SetActive(true);
     //////////
     boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
     boton_ok.GetComponent<Button>().onClick.AddListener(cambiarRopa);
     boton_derecha.GetComponent<Button>().onClick.AddListener(moverRopaDerecha);
     boton_izquierda.GetComponent<Button>().onClick.AddListener(moverRopaIzquierda);
     posicion_ropa_original=new List<Vector3>();
     for(int i=0;i<ropa_closet_lista.Count;i++)
            {
            posicion_ropa_original.Add(ropa_closet_lista[i].transform.localPosition);     
            }
            
    }

      public void moverRopaDerecha()
    {
        if(ropa_actual<ropa_closet_lista.Count-1){
            ropa_actual=ropa_actual+1;
            for(int i=0;i<ropa_closet_lista.Count;i++)
            {
            ropa_closet_lista[i].transform.localPosition=ropa_closet_lista[i].transform.localPosition+new Vector3(-80,0,0); 
            }
           
    } 
    }
    
        public void moverRopaIzquierda()
    {
        if(ropa_actual>0){
            ropa_actual=ropa_actual-1;
            for(int i=0;i<ropa_closet_lista.Count;i++)
            {
            ropa_closet_lista[i].transform.localPosition=ropa_closet_lista[i].transform.localPosition+new Vector3(80,0,0);
            }
             
        }
    }

    public void cambiarRopa()
    {
        Debug.Log("cambiar ropa");
        if(personaje_cerca){
        personaje_principal.GetComponent<SpriteRenderer>().sprite=ropa_closet_sprite_lista[ropa_actual];
             for(int i=0;i<ropa_closet_lista.Count;i++)
            {
            ropa_closet_lista[i].transform.localPosition=posicion_ropa_original[i];             
            }
        //Debug.Log(ropa_closet_lista.Count);  
        ropa_actual=0;
        PlayerPrefs.SetInt("interruptor_accion", 0);        
        grupo_closet.SetActive(false);
        boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();  
        //boton_ok.GetComponent<Button>().onClick.AddListener(abrir_closet);
        
        }
    }




    private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         personaje_cerca=true;
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         boton_ok.GetComponent<Button>().onClick.AddListener(abrir_closet);
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


       

    
    }                

