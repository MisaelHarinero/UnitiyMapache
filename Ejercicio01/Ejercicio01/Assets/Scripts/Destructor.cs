using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{   
    //Metodo para destruir los bloques
    void OnTriggerEnter2D(Collider2D block){
        if(block.tag =="Player"){
                Debug.Break();
                
        }else{
            Destroy(block.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
