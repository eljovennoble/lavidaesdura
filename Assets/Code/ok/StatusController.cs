using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusController : MonoBehaviour
{

    public GameObject Ventanas;
    public GameObject EstadisticasBtn;
    public GameObject HabilidadesBtn;
    public GameObject MisionesBtn;
    public GameObject estadisticas, habilidades, misiones;
    AudioSource mi_audiosource;
    
    
   
    public TextMeshProUGUI Personaje_NombreTMP,Personaje_LvTMP,Personaje_ExperienciaTMP;

    public TextMeshProUGUI EnergiaTMP,ConocimientoTMP,FelicidadTMP,Ganas_ComerTMP,PromedioTMP;
    public TextMeshProUGUI inteligenciaTMP,carismaTMP;


    public TextMeshProUGUI nombreHabilidadTMP,textoHabilidadTMP,mejorasHabilidadTMP;
    Personaje Jugador;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate =60;
        mi_audiosource=GetComponent<AudioSource>();
        
       
              
       
        Jugador = new Personaje("Charlie", 100, 10, 3, 25, 1, 1, 1, 0, 1, 1, 1);
        cargarDatos();

        Personaje_NombreTMP.text = Jugador.getNombre();
        Personaje_LvTMP.text = "Universitario "+"Lv."+Jugador.getNivel();
        Personaje_ExperienciaTMP.text = "Experiencia " + Jugador.getExperiencia() + " xp";

        //StatusTexto.GetComponent<TextMeshProUGUI>().text =
        EnergiaTMP.text="Energia: "+ Jugador.getEnergia() + " %";
        ConocimientoTMP.text="Conocimiento: "+ Jugador.getConocimiento().ToString();
        FelicidadTMP.text="Felicidad: "+ Jugador.getFelicidad().ToString();
        Ganas_ComerTMP.text="Ganas de comer: " + Jugador.getComida().ToString();
        PromedioTMP.text="Promedio: "+Jugador.getPromedioPersonaje().ToString();
        //DineroTMP.text= Jugador.getDinero() + "$"+"\n"+
        //Favor_ProfeTMP.text=Jugador.getCriterioProfesor() + "\n" +
       
       
        inteligenciaTMP.text = "Inteligencia: " + Jugador.getInteligencia();
        carismaTMP.text = "Carisma: " + Jugador.getCarisma();

    }   

// Update is called once per frame
void Update()
    {
        
    }



    public void to_estadisticas()
    {         
                habilidades.SetActive(false);
                misiones.SetActive(false);
                estadisticas.SetActive(true);
    }

    public void to_habilidades()
     {
                estadisticas.SetActive(false);
                misiones.SetActive(false);
                habilidades.SetActive(true); 
    }

    public void to_misiones()
     {
             habilidades.SetActive(false);
             estadisticas.SetActive(false);
             misiones.SetActive(true);
       
    }






 public void Hab_Avaricioso() {
        
        nombreHabilidadTMP.text ="Avaricioso";
        textoHabilidadTMP.text= "Solo piensas en el <b>dinero</b>. Por eso cada vez que tienes la oportunidad consigues unos pesos extras.";
        mejorasHabilidadTMP.text= "Lv1. Ganas 10$" + "\n"+
                                  "Lv2. Ganas 15$" + "\n"+
                                  "Lv3. Ganas 25$";

             }
    public void Hab_Elocuente() {
       
        nombreHabilidadTMP.text ="Elocuente";
        textoHabilidadTMP.text= "Tienes un poder de <b>convencimiento</b> por encima de la media. Eres bueno con las palabras.";
        mejorasHabilidadTMP.text= "Lv1. Carisma + 1" + "\n"+
                                  "Lv2. Carisma + 2" + "\n"+
                                  "Lv3. Carisma + 3";
            
        }


    public void Hab_Afortunado() {
        
        nombreHabilidadTMP.text ="Elocuente";
        textoHabilidadTMP.text= "Eres un chico con <b>suerte</b>. Eres el que siempre se encuentra dinero del pikete, al que nunca se le va la guagua, al que le sale la batería fácil en las pruebas.";
        mejorasHabilidadTMP.text= "Lv1. Suerte + 1" + "\n"+
                                  "Lv2. Suerte + 2" + "\n"+
                                  "Lv3. Suerte + 3";
                             }













    public void salirBtn()
    {
        
        salvarDatos();
        SceneManager.LoadScene("PrincipalScene");

    }
    





 void salvarDatos()
    {
        //nombre perssonaje
        PlayerPrefs.SetString("nombreP", Jugador.getNombre());
        ///atributos
        PlayerPrefs.SetInt("energiaP", Jugador.getEnergia());
        PlayerPrefs.SetInt("felicidadP", Jugador.getFelicidad());
        PlayerPrefs.SetInt("conocimientoP", Jugador.getConocimiento());
        PlayerPrefs.SetInt("dineroP", Jugador.getDinero());
        PlayerPrefs.SetInt("experenciaP", Jugador.getExperiencia());
        PlayerPrefs.SetInt("nivelP", Jugador.getNivel());
        ///atributos
        PlayerPrefs.SetInt("levelupP", Jugador.getLevelUpState());
        PlayerPrefs.SetInt("suerteP", Jugador.getSuerte());
        PlayerPrefs.SetInt("inteligenciaP", Jugador.getInteligencia());
        PlayerPrefs.SetInt("carismaP", Jugador.getCarisma());
        //puntos 
        PlayerPrefs.SetInt("phabilidad",Jugador.getPuntosHabilidad());
        PlayerPrefs.SetInt("ppersonalidad",Jugador.getPuntosPersonalidad());

    }

    void cargarDatos()
    {
        //nombre perssonaje
        Jugador.setNombre_Personaje(PlayerPrefs.GetString("nombreP", "Eribertico"));
        //atributos
        Jugador.setEnergia(PlayerPrefs.GetInt("energiaP", 100));
        Jugador.setFelicidad(PlayerPrefs.GetInt("felicidadP", 10));
        Jugador.setConocimiento(PlayerPrefs.GetInt("conocimientoP", 3));
        Jugador.setDinero(PlayerPrefs.GetInt("dineroP", 25));
        Jugador.setExperiencia(PlayerPrefs.GetInt("experenciaP", 0));
        Jugador.setNivel(PlayerPrefs.GetInt("nivelP", 1));
        ///atributos
        Jugador.setLevelUpState(PlayerPrefs.GetInt("levelupP", 0));
        Jugador.setSuerte(PlayerPrefs.GetInt("suerteP", 1));
        Jugador.setInteligencia(PlayerPrefs.GetInt("inteligenciaP", 1));
        Jugador.setCarisma(PlayerPrefs.GetInt("carismaP", 1));
        //puntos 
        Jugador.setPuntosHabilidad(PlayerPrefs.GetInt("phabilidad", 0));
        Jugador.setPuntosPersonalidad(PlayerPrefs.GetInt("ppersonalidad", 0));

    }




}
