using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizarInterfaz : MonoBehaviour
{
    public FichaPersonaje  ficha_personaje_principal;

    public TextMeshProUGUI energia_texto;
    public TextMeshProUGUI  felicidad_texto;
    public TextMeshProUGUI  dinero_texto;
    public TextMeshProUGUI  comida_texto;

    public TextMeshProUGUI nivel_text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       energia_texto.text= ficha_personaje_principal.getEnergia().ToString()+"%";
       felicidad_texto.text= ficha_personaje_principal.getFelicidad().ToString()+"%";
       dinero_texto.text= ficha_personaje_principal.getDinero().ToString()+"$";
       comida_texto.text= ficha_personaje_principal.getComida().ToString()+"%";

       nivel_text.text = "Universitario Lv." + ficha_personaje_principal.getNivel().ToString();
    }
}
