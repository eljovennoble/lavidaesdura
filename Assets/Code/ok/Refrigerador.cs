using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Refrigerador : MonoBehaviour
{
     public GameObject personaje_principal;
     public FichaPersonaje  ficha_personaje_principal;
     
    bool personaje_cerca;
    public GameObject boton_ok,boton_derecha,boton_izquierda;

    public TextMeshProUGUI dialogo_text;

    int HoraDeDormir;

     void Start()
    {
        HoraDeDormir=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         personaje_cerca=true;
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         boton_ok.GetComponent<Button>().onClick.AddListener(comer);
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



 public void comer()
    {
     
    

         if (ficha_personaje_principal.Comida_Personaje < 95 )
        {
            ficha_personaje_principal.setComida(ficha_personaje_principal.getComida() + Random.Range(10, 40));
        }
        else
        {
           dialogo_text.text= "Ya estoy lleno";
        }
    



    }




}
