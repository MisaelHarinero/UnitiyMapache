using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PJController : MonoBehaviour
{       //Establecemos el valor de la fuerza con la que salta nuestro mapache
        public float fuerzaSalto = 10f;
        private bool enSuelo = true;
        public Transform ComprobarSuelo;
        public float comprobadorRadio = 0.007f;
        public LayerMask mascaraSuelo;
        public bool doubleJumpUsed = false;
        private Animator animator;
        private bool run = false;
        private float velocity = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake(){ // Metodo  que se  ejecuta al iniciar el juego donde deberemos obtener todas las instancias a los objetos utilizados en el mismo
        animator = GetComponent<Animator>(); // Obtain Animator reference
    }

    // Update is called once per frame
    void Update()
    {
            updateState();
    }
    void updateState(){
            if (Input.GetMouseButtonDown(0)  )
            {
                if(run){

                        if(enSuelo || !doubleJumpUsed){
                            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,fuerzaSalto);    
                            doubleJumpUsed = true;    
                         }

                }else{
                    run = true;
                    NotificationCenter.DefaultCenter().PostNotification(this,"pjStartRun");
                }
               





            }


    }
    void FixedUpdate(){
        animator.SetFloat("velocity",GetComponent<Rigidbody2D>().velocity.x);
        if(run){
                GetComponent<Rigidbody2D>().velocity = new Vector2(velocity,GetComponent<Rigidbody2D>().velocity.y);
        }
        enSuelo = Physics2D.OverlapCircle(ComprobarSuelo.position,comprobadorRadio,mascaraSuelo);
         animator.SetBool("isOnFloor",enSuelo);   

        if(enSuelo){
            doubleJumpUsed = false;
        }

    }
}
