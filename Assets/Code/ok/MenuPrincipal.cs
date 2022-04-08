using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          // SceneManager.LoadScene("escena01 casa");
    }

 

 public void NuevaPartida(){ 
     Debug.Log("Nueva partida"); 
     SceneManager.LoadScene("escena 00 opening");
     }
 public void ContinuarPartida(){
     Debug.Log("Continuar Patrida"); 
     SceneManager.LoadScene("escena01 casa");
     }
 public void Opciones(){
      Debug.Log("Opciones"); 
     SceneManager.LoadScene("escena01 casa");
     }

}
