using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
List<string> lista_objetivos;

    // Start is called before the first frame update
    void Start()
    {
       lista_objetivos=new List<string>();
       lista_objetivos.Add("* Buscar algo de ropa en closet");
       lista_objetivos.Add("* Pedirle dinero a papá");
       lista_objetivos.Add("* Sacar la basura");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
