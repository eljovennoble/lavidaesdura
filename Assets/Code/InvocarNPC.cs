using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvocarNPC : MonoBehaviour
{
    public Transform punto_invocacion01,punto_invocacion02;
    public List<Sprite> npc_lista_sprite;

    public GameObject npc_prefab;

    public bool invocar_npc_state;

    float tiempo_invocacion;

    // Start is called before the first frame update
    void Start()
    {
        invocar_npc_state=true;
        StartCoroutine(invocandoNPC());
     }

    
     
     IEnumerator  invocandoNPC()
    {
        tiempo_invocacion=Random.Range(1.0f,2.0f);
        yield return new WaitForSeconds(tiempo_invocacion);       
        if(invocar_npc_state){ 
            Debug.Log("Invocando NPC"); 
            switch(Random.Range(0,2))
            {
             case 0: 
             GameObject npc_temporal=Instantiate(npc_prefab, punto_invocacion01.position, punto_invocacion01.rotation); 
             npc_temporal.GetComponent<SpriteRenderer>().sprite= npc_lista_sprite[Random.Range(0,npc_lista_sprite.Count)];
             break;
             case 1: GameObject npc_temporal2=Instantiate(npc_prefab, punto_invocacion02.position, punto_invocacion02.rotation); 
             npc_temporal2.GetComponent<SpriteRenderer>().sprite= npc_lista_sprite[Random.Range(0,npc_lista_sprite.Count)];
             npc_temporal2.GetComponent<SpriteRenderer>().flipX=true;
             npc_temporal2.GetComponent<SpriteRenderer>().sortingLayerName="npc02";
             npc_temporal2.GetComponent<NPC>().setDerecha(true);
             break; 
            }
         
            StartCoroutine(invocandoNPC());
            }    
    } 


}
