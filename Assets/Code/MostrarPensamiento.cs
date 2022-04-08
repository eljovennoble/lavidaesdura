using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MostrarPensamiento : MonoBehaviour
{
public GameObject dialogo_grupo;

public TextMeshProUGUI mi_textmeshpro;
public string mi_texto;
    


    private void OnTriggerEnter2D (Collider2D other) {
        if(other.name=="lorenzito_player"){
       // dialogo_grupo.SetActive(true);
       // mi_textmeshpro.text=mi_texto;
        }
       
    }

     private void OnTriggerExit2D (Collider2D other) {
         if(other.name=="lorenzito_player"){
         //dialogo_grupo.SetActive(false);
         }
    }
 
}
