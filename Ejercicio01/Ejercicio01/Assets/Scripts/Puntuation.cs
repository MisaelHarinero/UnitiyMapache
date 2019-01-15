using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuation : MonoBehaviour
{
    private int puntuation = 0;
    public TextMesh marcador;
    // Start is called before the first frame update
    void Start()
    {
      NotificationCenter.DefaultCenter().AddObserver(this,"addPoints");

    }
    void updateMarcador(){
      marcador.text = puntuation.ToString();
    }
    void addPoints(Notification notification){
        int incrementPoints = (int) notification.data;
        puntuation = puntuation+incrementPoints;
        updateMarcador();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
