using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    public AudioClip musica_fondo;
    // Start is called before the first frame update
    void Start()
    {
       this.GetComponent<AudioSource>().clip=musica_fondo;
       this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    

}
