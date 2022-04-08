using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    
    public Image imagenObjeto;
     public AudioClip tapp;
    public AudioClip dinero;
    int IdObjeto;
    int cantidadObjetos;
    List<int> misObjetos;
    List<Objeto> Tienda;
    Objeto ObjetoAlatorioT;
    public TextMeshProUGUI ObjetoInfo;
    public TextMeshProUGUI ObjetoNombre;
    public TextMeshProUGUI ObjetoCantidad;
 
    public Sprite cafeImagen, dipironaImagen, meriendaImagen;


    int cantidadCafe;
    int cantidadDipironas;
    int cantidadMeriendas;
    int dineroActual;

//////////////

     public GameObject personaje_principal;
     public FichaPersonaje  ficha_personaje_principal;
     
    bool personaje_cerca;
    public GameObject boton_ok,boton_derecha,boton_izquierda;

    public TextMeshProUGUI dialogo_text;






    void Start()
    {
        cargarDatosT();
        cantidadCafe = 0;
        cantidadDipironas = 0;
        cantidadMeriendas = 0;
        IdObjeto = 0;
        Tienda = new List<Objeto>();
        misObjetos = new List<int>();
       // ObjetoInfo = GameObject.Find("DescripcionTMP");
       // ObjetoNombre = GameObject.Find("NombreObjetoTMP");
       // ObjetoCantidad = GameObject.Find("LlevasTMP");
        objetosEnlaTienda();
        ObjetoNombre.GetComponent<TextMeshProUGUI>().text = Tienda[IdObjeto].getNombreObjeto() +"  "+Tienda[IdObjeto].getPrecioObjeto() +" $";
        ObjetoInfo.GetComponent<TextMeshProUGUI>().text = Tienda[0].getTextoObjeto();
        ObjetoCantidad.GetComponent<TextMeshProUGUI>().text = "Tienes " + cantidadCafe + " " + Tienda[IdObjeto].getNombreObjeto() + "s";
                
    }

    public void comprarObjeto()
    {
        if (ficha_personaje_principal.Dinero_Personaje < Tienda[IdObjeto].getPrecioObjeto())
        {
           
               //no tengo dinero suficiente

        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(dinero);
            if (IdObjeto == 0) { cantidadCafe++; }
            if (IdObjeto == 1) { cantidadDipironas++; }
            if (IdObjeto == 2) { cantidadMeriendas++; }
            if (IdObjeto == 0) { ObjetoCantidad.text = "Tienes " + cantidadCafe + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; }
            if (IdObjeto == 1) { ObjetoCantidad.text = "Tienes " + cantidadDipironas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; }
            if (IdObjeto == 2) { ObjetoCantidad.text = "Tienes " + cantidadMeriendas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; }
            dineroActual = dineroActual - Tienda[IdObjeto].getPrecioObjeto();
          
        }
    }

    public void siguienteObjeto() {
       
        IdObjeto = IdObjeto + 1;
        if (IdObjeto > 2) { IdObjeto = 0; }
        ObjetoNombre.text = Tienda[IdObjeto].getNombreObjeto() + "  " + Tienda[IdObjeto].getPrecioObjeto() + " $";
        ObjetoInfo.text = Tienda[IdObjeto].getTextoObjeto();
       if(IdObjeto==0) {ObjetoCantidad.text = "Tienes " + cantidadCafe +" "+ Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite = cafeImagen; }
       if(IdObjeto==1) {ObjetoCantidad.text = "Tienes " + cantidadDipironas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite = dipironaImagen; }
       if(IdObjeto==2) {ObjetoCantidad.text =  "Tienes " + cantidadMeriendas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite = meriendaImagen; }


    }

    public void anteriorObjeto()  {
      
        IdObjeto = IdObjeto-1;
        if (IdObjeto<0) { IdObjeto = Tienda.Count-1; }
        ObjetoNombre.text = Tienda[IdObjeto].getNombreObjeto() + "  " + Tienda[IdObjeto].getPrecioObjeto() + " $";
        ObjetoInfo.text = Tienda[IdObjeto].getTextoObjeto();
        if (IdObjeto == 0) {ObjetoCantidad.text = "Tienes " + cantidadCafe + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite= cafeImagen; }
        if (IdObjeto == 1) {ObjetoCantidad.text = "Tienes " + cantidadDipironas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite = dipironaImagen; }
        if (IdObjeto == 2) {ObjetoCantidad.text = "Tienes " + cantidadMeriendas + " " + Tienda[IdObjeto].getNombreObjeto() + "s"; imagenObjeto.sprite = meriendaImagen; }

    }

    public void okBtn()
    {
     

    }


    void objetosEnlaTienda()
    {

        ObjetoAlatorioT= new Objeto("Café", "Llamado por muchos el elixir de los dioses, la semilla mágica, el aroma divino, muchos le deben su título universitario a esta bebida.", 0,1);
        Tienda.Add(ObjetoAlatorioT);
        ObjetoAlatorioT=new Objeto("Dipirona", "La dipirona ayuda cuando tienes dolor de cabeza. Es un artículo de primera necesidad en la vida de cualquier universitario.", 1, 2);
        Tienda.Add(ObjetoAlatorioT);
        ObjetoAlatorioT =new Objeto("Merienda", "Un pancito y un refresco nunca están de más.", 2,10);
        Tienda.Add(ObjetoAlatorioT);
   
    }




    public void salvarDatosT()
    {
        
        PlayerPrefs.SetInt("dineroP", dineroActual);
    }

    public void cargarDatosT()
    {
        dineroActual=PlayerPrefs.GetInt("dineroP",0);
        

    }




private void OnTriggerEnter2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         personaje_cerca=true;
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         //boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         //boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         boton_ok.GetComponent<Button>().onClick.AddListener(abrir_tienda);
        } 
     }
    
     private void OnTriggerExit2D(Collider2D other) 
        
     {
        if(other.name=="lorenzito_player")
        {
         boton_ok.GetComponent<Button>().onClick.RemoveAllListeners();
         //boton_derecha.GetComponent<Button>().onClick.RemoveAllListeners();
         //boton_izquierda.GetComponent<Button>().onClick.RemoveAllListeners();   
         personaje_cerca=false;    
        } 
     }


 public void abrir_tienda()
 {
     
 }





 
}
