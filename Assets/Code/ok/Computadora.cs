using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Computadora : MonoBehaviour
{
     public GameObject personaje_principal;
     public FichaPersonaje  ficha_personaje_principal;
     
    bool personaje_cerca;
    public GameObject boton_ok,boton_derecha,boton_izquierda;

    public TextMeshProUGUI dialogo_text;

    public GameObject barra_progreso;
    float progreso;
    int HoraDeDormir;
    public GameObject experienciaTMP;
    

     void Start()
    {
        HoraDeDormir=0;
        progreso=0;
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
         boton_ok.GetComponent<Button>().onClick.AddListener(jugar_pc);
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



 public void jugar_pc()
    {
     Debug.Log("jugar en la computadora");
     if (HoraDeDormir == 1)
        {
           // MostarCartel("No tengo ganas de jugar a esta hora");
          dialogo_text.text= "No tengo ganas de jugar a esta hora";
        }

        else if (ficha_personaje_principal.Energia_Personaje > 20)
        {
            barra_progreso.SetActive(true);
            StartCoroutine(aumentar_barra_progreso());
           
        }
        else
        {
            //Reproducir sonido negativo
           // MostarCartel("Estoy muy cansado. Debería dormir un poco");
           dialogo_text.text= "Estoy muy cansado. Debería dormir un poco";
        }
    }


    IEnumerator aumentar_barra_progreso()
    {
        while(progreso<1.1f)
        { 
        barra_progreso.GetComponent<Slider>().value=progreso;
        progreso=progreso+ 0.1f;        
        yield return new WaitForSeconds(0.3f);
        }
        ficha_personaje_principal.setFelicidad(ficha_personaje_principal.getFelicidad() + Random.Range(20,50));
        ficha_personaje_principal.setComida(ficha_personaje_principal.getComida() - Random.Range(10, 20));
        ficha_personaje_principal.setEnergia(ficha_personaje_principal.getEnergia() - Random.Range(20,41));
        progreso=0;
        barra_progreso.SetActive(false);
        StartCoroutine(aumentar_experiencia());
    }


 
    IEnumerator aumentar_experiencia()
    {
      experienciaTMP.SetActive(true);
      int experiencia_temporal=Random.Range(5, 16);
      ficha_personaje_principal.setExperiencia(ficha_personaje_principal.getExperiencia() + experiencia_temporal);
      experienciaTMP.GetComponent<TextMeshProUGUI>().text="+"+ experiencia_temporal +"xp";
      yield return new WaitForSeconds(1f);      
      experienciaTMP.SetActive(false);

    }



}
