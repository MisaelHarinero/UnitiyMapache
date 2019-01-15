using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour
{
    private int incrementPoints = 5;
    void OnTriggerEnter2D(Collider2D collider){
        NotificationCenter.DefaultCenter().PostNotification(this,"addPoints",incrementPoints);
        Destroy(gameObject);
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
