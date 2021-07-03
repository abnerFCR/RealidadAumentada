using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Espacios
{
    
    public class VerificarPisos : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            for(int i = 0 ; i < 3 ; i++ )
            {
                if(Pisos.primera){
                    for (int j = 0; j < 3; j++)
                    {
                        Espacio espacio = new Espacio(false, 0, 0, 0, 0, 0);
                        Pisos.espacios[j] = espacio;
                    }
                    Pisos.primera= !Pisos.primera;
                }

                RawImage cuadro = GameObject.Find("estadoP"+(i+1)).GetComponent<RawImage>(); 
                if(Pisos.espacios[i].getEstado()==true)
                {
                    //AGREGAR UN COLOR ROJO
                    cuadro.color = Color.red;
                }
                else
                {
                    //AGREGAR UN COLOR VERDE
                    cuadro.color = Color.green;
                }
            }
            
        }
        void Update()
        {
            
        }
    }
}