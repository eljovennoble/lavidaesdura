using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalidaCasa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    


    private void OnTriggerEnter2D(Collider2D other) 
        
     {

        if(other.name=="lorenzito_player")
        {
         //SceneManager.LoadScene("escena03 tienda");
         other.GetComponent<Transform>().position=new Vector3(75.42f,-0.5f,0);
        } 
     }

}
