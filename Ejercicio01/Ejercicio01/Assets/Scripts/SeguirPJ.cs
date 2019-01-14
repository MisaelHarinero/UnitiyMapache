using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPJ : MonoBehaviour
{
    public Transform personaje;
    public float separation = 6f;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(personaje.transform.position.x + separation,transform.position.y, transform.position.z);
    }
}
