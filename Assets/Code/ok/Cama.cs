using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cama : MonoBehaviour
{
  public GameObject personaje_principal;
     public FichaPersonaje  ficha_personaje_principal;
     
    bool personaje_cerca;
    public GameObject boton_ok,boton_derecha,boton_izquierda;

    public TextMeshProUGUI dialogo_text;

    int HoraDeDormir;
    public GameObject barra_progreso;
    float progreso;


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
         boton_ok.GetComponent<Button>().onClick.AddListener(dormir);
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



 public void dormir()
    {
     Debug.Log("Dormir");
     if (HoraDeDormir == 1)
        {
           // MostarCartel("No tengo ganas de jugar a esta hora");
          dialogo_text.text= "No tengo ganas de jugar a esta hora";
        }

        else if (ficha_personaje_principal.Energia_Personaje < 95)
        {
        barra_progreso.SetActive(true);   
        StartCoroutine(aumentar_barra_progreso());  
        //HoraDeDormir = 0;
        //if (myDia.getNumDia() == 6) { myDia.setNumSemana(myDia.getNumSemana() + 1); myDia.setNumDia(0); myDia.setNumHora(0); }
        //else{myDia.setNumDia(myDia.getNumDia() + 1);  myDia.setNumHora(0); }
        //salvarDatos();
        //pantallaNegra.GetComponent<LogicaFade>().irA("PrincipalScene");
        }
        else
        {
           dialogo_text.text= "No tengo sueño ahora";
        }
    
    }




  IEnumerator aumentar_barra_progreso()
    {
        while(progreso<1.1f)
        { 
        barra_progreso.GetComponent<Slider>().value=progreso;
        progreso=progreso+ 0.1f;        
        yield return new WaitForSeconds(0.1f);
        }
        ficha_personaje_principal.setEnergia(ficha_personaje_principal.getEnergia() + Random.Range(40, 50));
        progreso=0;
        barra_progreso.SetActive(false);
    }







}
