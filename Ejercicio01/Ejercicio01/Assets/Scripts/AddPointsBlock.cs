using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPointsBlock : MonoBehaviour
{
  private int incrementPoints = 1;
  private bool isCollided = false;
    void OnCollisionEnter2D(Collision2D collision){
        if (!isCollided  && collision.gameObject.tag=="Player") {
          if (collision.contacts[0].collider.gameObject.name!="Cabeza") {
            NotificationCenter.DefaultCenter().PostNotification(this,"addPoints",incrementPoints);
            isCollided = true;
          }
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
