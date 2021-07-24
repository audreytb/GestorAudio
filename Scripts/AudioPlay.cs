using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class AudioPlay : MonoBehaviour
{
    public TextMeshProUGUI textElement;
    public AudioSource au;
    public GameObject panelDialogo;
    public UpdateResources Upresourse;
    float count = 0;

    void Start()
    {
        Upresourse = FindObjectOfType<UpdateResources>();
        /* print(Upresourse.miDiccioA["Persian"]+" "+Upresourse.miDiccioT["Persian"]); */
    }

    public void EjecutarConjuntoAudios(String variable){
        panelDialogo.SetActive(true);
         var audioClip = Upresourse.miDiccioA[variable];
         print(variable);
         au.Stop();       
         au.PlayOneShot(audioClip as AudioClip);
        
    }
    public IEnumerator EjecutarConjuntoDialogos(String variable){// COLLISION LLEGA DIRECTAMENTE AQUI!
        textElement.text = "";//Para la impresión de texto
        panelDialogo.SetActive(true);// Hacemos aparecer el panel de texto
        String textFile =  Upresourse.miDiccioT[variable] as String; 
    
        foreach(char caracter in textFile){
             /* if (Input.GetKeyDown(KeyCode.Space)) { */
             if (count <10) {
                 textElement.text = "";
                 textElement.text = textFile; 
                 print("TEXTFILE: "+ textFile);
                 /* au.Stop(); */
                 /* yield return new WaitForSeconds(0.04f); */
                 count++;
                 
             }
             else {
                textElement.text = textElement.text + caracter;
             }
             
                yield return new WaitForSeconds(0.04f);
        }
        
        
        
        
    }

}