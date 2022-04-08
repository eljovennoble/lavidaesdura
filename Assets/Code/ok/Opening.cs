using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    List <string> texto_inicial;
    public List <Sprite> grupo_imagenes;
    public GameObject texto_opening;
    public Image image_opening;
    
    public GameObject ingenieros_image,arquitectos_image,licenciados_image,artistas_image,corazon_image,facultades_grupo,el_brayan_image;
    
    public Sprite corazon_roto;
    int texto_actual;


    // Start is called before the first frame update
    void Start()
    {

        texto_inicial = new List<string>();
       
        texto_inicial.Add("Ingenieros");
        texto_inicial.Add("Arquitectos");
        texto_inicial.Add("Licenciados");
        texto_inicial.Add("Artistas");
        texto_inicial.Add("Hace mucho tiempo");
        texto_inicial.Add("Las cuatro facultades vivían en armonía");
        texto_inicial.Add("Pero todo cambió cuando El Brayan llegó");
        texto_inicial.Add("Solo un crack como Eribertico");
        texto_inicial.Add("Maestro en Tallas de la Vida podía detenerlo");
        texto_inicial.Add("Pero cuando la Universidad más lo necesitaba");
        texto_inicial.Add("Se graduó");
        texto_inicial.Add("Después de dos años");
        texto_inicial.Add("Mi hermana y yo entramos en la escuela y conocimos al hermano menor de aquel crack");
        texto_inicial.Add("Un joven llamado Lorenzito");
        texto_inicial.Add("Y aunque era igual de inteligente que su hermano");
        texto_inicial.Add("Tenía mucho que aprender todavía antes de poder ayudar a alguien");
        texto_inicial.Add("Pero yo creo que Lorenzito podrá ayudarnos");          
        texto_opening.GetComponent<TextMeshProUGUI>().text=texto_inicial[0];
        //image_opening.sprite=grupo_imagenes[0];
        texto_actual=0;
        texto_opening.transform.LeanMoveLocal(new Vector2(0,-275),1).setEaseInOutQuart();
        ingenieros_image.LeanMoveLocal(new Vector2(-150,0),1).setEaseInOutQuart();
        
       
    }

    

    public void texto_siguiente()
    {
        

        if(texto_actual<texto_inicial.Count-1)
        {

        texto_actual=texto_actual+1;
        if(texto_actual==1){arquitectos_image.LeanMoveLocal(new Vector2(0,150),1f).setEaseInOutQuart();}
        if(texto_actual==2){licenciados_image.LeanMoveLocal(new Vector2(150,0),1f).setEaseInOutQuart();}
        if(texto_actual==3){artistas_image.LeanMoveLocal(new Vector2(0,-150),1f).setEaseInOutQuart();}
        if(texto_actual==4){rotar();}
        if(texto_actual==5){corazon_image.LeanScale(Vector2.one,0.8f);}
        if(texto_actual==6){el_brayan_image.LeanMoveLocal(new Vector2(300,20),2f).setEaseInOutQuart().setOnComplete(romper_corazon);}

        texto_opening.GetComponent<TextMeshProUGUI>().text=texto_inicial[texto_actual];
        image_opening.sprite=grupo_imagenes[texto_actual];
        texto_opening.transform.LeanMoveLocal(new Vector2(0,-275),3).setEaseInOutQuart();
        }
       else
       {
           SceneManager.LoadScene("escena01 casa");
       }   
    }



   void ocultar_personajes()
   {
     ingenieros_image.SetActive(false);
      arquitectos_image.SetActive(false);
       licenciados_image.SetActive(false);
        artistas_image.SetActive(false);
   }

   void rotar()
   {
    
     facultades_grupo.LeanRotateAroundLocal(Vector3.forward, -100f, 12f).setLoopPingPong();
     ingenieros_image.LeanRotateAroundLocal(Vector3.forward, 100f, 12f).setLoopPingPong();
     arquitectos_image.LeanRotateAroundLocal(Vector3.forward, 100f, 12f).setLoopPingPong();
     licenciados_image.LeanRotateAroundLocal(Vector3.forward, 100f, 12f).setLoopPingPong();
     artistas_image.LeanRotateAroundLocal(Vector3.forward, 100f, 12f).setLoopPingPong();    
  }

  void romper_corazon()
  {
    corazon_image.GetComponent<Image>().sprite=corazon_roto;
  }



}
