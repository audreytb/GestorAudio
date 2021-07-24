using System.Collections;/* 
using System.Collections.Generic; */
using UnityEngine;

public class Colision1 : MonoBehaviour
{
    
    public AudioPlay audio;
    public GameObject panelDialogo;
    public void Start(){
        panelDialogo.SetActive(false);
        
        
    }
    void OnTriggerEnter (Collider other){
        if(other.gameObject.tag == "Player"){
            StartCoroutine(audio.EjecutarConjuntoDialogos("primero"));
            /* audio.EjecutarConjuntoDialogos("Cubis"); */
             audio.EjecutarConjuntoAudios("primero");
            
        }
    }
}
