using System.Collections;/* 
using System.Collections.Generic; */
using UnityEngine;

public class Colision : MonoBehaviour
{
    public UpdateResources Upresourse;

    public AudioPlay audio;
    public GameObject panelDialogo;
    public string[] DiaScene;// Almacena un arreglo donde los elementos son P1,P2,P3
    string dialogos;
    int i;

    public void Start(){
        Upresourse = FindObjectOfType<UpdateResources>();
        panelDialogo.SetActive(false);// Desaparecer el panel de texto al iniciar la escena
        dialogos =  Resources.Load<TextAsset>("Textos/primero").text; // Contiene P1,P2,P3
        fragmentar(dialogos);// Separa P1,P2,P3
    }
    void OnTriggerEnter (Collider other){
        if(other.gameObject.tag == "Player"){ //Si colisiona con el jugador
        
            for(i = 0; i <DiaScene.Length; i++){
                StartCoroutine(audio.EjecutarConjuntoDialogos(DiaScene[i])); // Ejecutar dialogo P1
                                                                       // Ejecutar dialogo P2
                                                                            // Ejecutar dialogo P3
            audio.EjecutarConjuntoAudios(DiaScene[i]);
            
            }
            
            
            }
            /* StartCoroutine(audio.EjecutarConjuntoDialogos("segundo"));            
            audio.EjecutarConjuntoAudios("segundo"); */
            
        }
    
    void fragmentar(string vararchivo){
        DiaScene = vararchivo.Split(';');
    }
}
