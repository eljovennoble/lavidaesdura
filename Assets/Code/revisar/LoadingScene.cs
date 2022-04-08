using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
    GameObject barradecarga;
    GameObject consejoTexto;
    float tiempoInicial;
    float tiempoFinal;
    List<string> consejosAleatorios;
    int numeroAleatorio;

    
    void Start()
    {

        numeroAleatorio = Random.Range(0, 20);
        guardarConsejos();
        consejoTexto = GameObject.Find("ConsejoTMP");
        barradecarga = GameObject.Find("SliderCarga");
        tiempoInicial = 0;
        tiempoFinal = 10;
        consejoTexto.GetComponent<TextMeshProUGUI>().text =
        consejosAleatorios[numeroAleatorio];
    }
    //EE009E

    void Update()
    {


        if (tiempoInicial > tiempoFinal-2)
        {
           SceneManager.LoadScene("TitleScene");
        }

        else
        {
            tiempoInicial += Time.deltaTime;
            barradecarga.GetComponent<Slider>().value = tiempoInicial;
        }

    }




    void guardarConsejos()
    {
        consejosAleatorios = new List<string>();
        consejosAleatorios.Add("Consejo #1:\n Tienes que organizar tus prioridades, ya no eres un niño. \n Ahora tienes responsabilidades");
        consejosAleatorios.Add("Consejo #2:\n Eres un estudiante universitario. \n Necesitas estudiar si quieres terminar el año. ");
        consejosAleatorios.Add("Consejo #3:\n Eribertico está aprendiendo a tocar guitarra.");
        consejosAleatorios.Add("Consejo #4:\n Con hambre no puedes hacer nada bien. Come!!!");
        consejosAleatorios.Add("Consejo #5:\n Si no descansas te puedes quedar dormido en el aula ");
        consejosAleatorios.Add("Consejo #6:\n No puedes dormir en trabajo, pero si puedes dormir en la escuela. Trata de que el profesor no se de cuenta.");
        consejosAleatorios.Add("Consejo #7:\n El café es uno de los mejores amigos en tu vida de universitario");
        consejosAleatorios.Add("Consejo #8:\n De vez en cuando necesitas salir a desconectar. \n Si no, te vas a fundir.");
        consejosAleatorios.Add("Consejo #9:\n No descuides el trabajo.\n Recuerda que de él te llega el dinero para tus caprichos");
        consejosAleatorios.Add("Consejo #10:\n Necesitas dormir bien para rendir al máximo en el día");
        consejosAleatorios.Add("Consejo #11:\n Estudia sistemáticamente.\n Nunca sabes cuando el profe ponga un pregunta escrita.");
        consejosAleatorios.Add("Consejo #12:\n Recuerda ahorrar dinero para la comida");
        consejosAleatorios.Add("Consejo #13:\n Los domingos en la noche recibirás recibirás una mesada de parte de tu familia.");
        consejosAleatorios.Add("Consejo #14:\n A veces es mejor guardar el dinero. \n ¿Para qué gastar todo en una noche?  ");
        consejosAleatorios.Add("Consejo #15:\n Obvio. Los sábados y domingos no hay clases");
        consejosAleatorios.Add("Consejo #16:\n El día a día puede resultar tedioso pero no te confíes de tanta calma.");
        consejosAleatorios.Add("Consejo #17:\n Necesitas buenas notas, al menos necesitas estar aprobado en todo si quieres disfrutar de tus vacaciones. ");
        consejosAleatorios.Add("Consejo #18:\n Puedes terminar con las mejores notas del aula si te esfuerzas");
        consejosAleatorios.Add("Consejo #19:\n A cada rato hay eventos deportivos y culturales ");
        consejosAleatorios.Add("Consejo #20:\n Eres un universitario, el dinero escasea. Tenlo en cuenta."); 
    }

}
