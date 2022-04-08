using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ObjetoRandom : MonoBehaviour
{
          
    bool personaje_cerca;
    public GameObject boton_ok;
    public TextMeshProUGUI dialogo_text;

    int HoraDeDormir;

    private string nombre_objeto_random;

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
         nombre_objeto_random=this.name;
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         boton_ok.GetComponent<Button>().onClick.AddListener(comentario_random);
        } 
     }
    
     private void OnTriggerExit2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         dialogo_text.text= "";
         personaje_cerca=false;    
        } 
     }



 public void comentario_random()
    {
     switch(nombre_objeto_random)
     {
      case "televisor": dialogo_text.text= "No hay nada interesante en la TV"; break;
      //case "refrigerador": dialogo_text.text= "No tengo hambre ahora"; break;
      
     }
     


    }





}
