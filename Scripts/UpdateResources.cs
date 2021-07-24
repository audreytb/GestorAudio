using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;
using UnityEngine.UI;
public class UpdateResources : MonoBehaviour
{
    public String[] AudioScene;// Contenedor de audiotext
    String AudioText;
    public String[] AudioSce; // contenedor de los nietos de audiotext(P1,P2,P3 Son padres, textos y audios )
    String dialogo;// Segundo contenedor de los elementos del hijo de audiotext (P1,P2,P3)
    String textUnit;
    public Hashtable miDiccioA = new Hashtable();
    public Hashtable miDiccioT = new Hashtable();
    
    
    int i;
    // Start is called before the first frame update
    void Start()
    {
        /* print("START"); */
        AudioText =  Resources.Load<TextAsset>("Textos/Audios").text; // Leer archivo de texto: Audios
        /*  */

        /*  */
        fragmentar(AudioText);
        /* print("AUDIOSCENE: ");
        imprimir(AudioScene);
        print("----------------------"); */
        /* for(i = 0; i <AudioScene.Length; i++){
            
        } */
        for(i = 0; i <AudioScene.Length; i++){
            dialogo =  Resources.Load<TextAsset>("Textos/"+AudioScene[i]).text;
            fragmentarD(dialogo);
            /* imprimir(AudioSce); */
            load(AudioSce);
        }
       /*  load(AudioScene); */
       
       /*  miDiccioA.Clear();
        miDiccioT.Clear(); */
    }

    // Update is called once per frame
    void fragmentar(string vararchivo){
        AudioScene = vararchivo.Split(';');
    }
    void fragmentarD(string vararchivo){
        AudioSce = vararchivo.Split(';');
    }
    void imprimir(String[] arreglo){
        for(i = 0; i <arreglo.Length; i++){
            print(arreglo[i]);
        }
    }
    /* Load carga los recursos finales, el texto que contienen los nietos de audiotext */
    void load(string[] scenAud){
        for(i = 0; i <scenAud.Length; i++){
            textUnit =  Resources.Load<TextAsset>("Textos/"+scenAud[i]).text;// Textos/P1 ---Textos/P2---Texto/P3
            var audioUnit = Resources.Load<AudioClip>("Sound/"+scenAud[i]); // Audios/P1 ---Audios/P2----Audios/P3

            miDiccioT.Add(scenAud[i], textUnit);//P1,  Este es el primer dialogo, presione enter para continuar
            miDiccioA.Add(scenAud[i], audioUnit);//P1, la la lalaaa miDiccioT("P1") -> texto, miDiccioA("P1") -> Audio
                                                                  //miDiccioT("P2") -> texto, miDiccioA("P2") -> Audio
                                                                  //...
            /* print("Diccionario-> Texto: "+miDiccioT[scenAud[i]]+" Audio: " +miDiccioA[scenAud[i]]); */
        }
        /* print(miDiccioA["Persian"]+" "+miDiccioT["Persian"]); */
        
    }
}
