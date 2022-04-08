using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrasNegras : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.SetPositionAndRotation(player.transform.position,this.transform.rotation);
    }
}
