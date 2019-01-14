using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] blocks;
    // Start is called before the first frame update
    public float minimumTime = 1f;
    public float maximumTime = 2f;
    void Generate(){
        Instantiate(blocks[Random.Range (0,blocks.Length)],transform.position, Quaternion.identity);
        Invoke("Generate",Random.Range(minimumTime,maximumTime));

    }
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this,"pjStartRun");
        
    }
    void pjStartRun(Notification notification){
           Generate(); 
    }
}
