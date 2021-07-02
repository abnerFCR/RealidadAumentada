using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Espacios
{
        

    public class GestorPisos : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            for(int i = 0 ; i < 3 ; i++ )
            {
                if(Pisos.espacios[i].getEstado())
                {
                    this.setParedes(Pisos.espacios[i].getPiso());
                    this.setColor(Pisos.espacios[i].getPiso(),Pisos.espacios[i].getIluminacion());
                    this.setEscritorioSilla(true,Pisos.espacios[i].getPiso(),Pisos.espacios[i].getPosicionSilla());
                    this.setEscritorioSilla(false,Pisos.espacios[i].getPiso(),Pisos.espacios[i].getPosicionEscritorio());
                    this.setCuadro(Pisos.espacios[i].getPiso(), Pisos.espacios[i].getPosicionCuadro());
                }
                else
                {
                    this.ClearChildren(Pisos.espacios[i].getPiso());
                }
            }

        }


        public void setColor(int piso, int iluminacion)
        {
            
            Light directionalLight = GameObject.Find("dlPiso"+(piso+1)).GetComponent<Light>(); 
            //GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            switch(iluminacion)
            {
                case 0:
                    //ROJO
                    directionalLight.color = Color.red;
                break;
                case 1:
                    directionalLight.color = Color.yellow;
                    //AMARILLO
                break;
                case 2:
                    directionalLight.color = Color.blue;
                    //AZUL
                break;
                default:
                    //Error
                break;
            }
            //directionalLight.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
            
        }
        public void setEscritorioSilla(bool silla,int piso, int posicion){
            GameObject gameObject;
            if(silla){
                gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                gameObject.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
                gameObject.transform.localScale = new Vector3((float)2,(float)2,(float)2);
                gameObject.transform.rotation = Quaternion.Euler((float)0,(float)0,(float)0);
            }else{
                gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                gameObject.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
                gameObject.transform.localScale = new Vector3((float)2,(float)2,(float)3);
                gameObject.transform.rotation = Quaternion.Euler((float)0,(float)0,(float)0);
            }

            

            switch(posicion)
            {
                case 0:
                    //SUPERIOR IZQUIERDA
                    gameObject.transform.position = new Vector3((float)-8.01,(float)1,(float)5.1);
                break;
                case 1:
                    //SUPERIOR DERECHA
                    gameObject.transform.position = new Vector3((float)3.83,(float)1,(float)5.1);
                break;
                case 2:
                    //CENTRO
                    gameObject.transform.position = new Vector3((float)0,(float)1,(float)0);
                break;
                case 3:
                    //INFERIOR IZQUIERDA
                    gameObject.transform.position = new Vector3((float)-8.01,(float)1,(float)-5.03);
                break;
                case 4:
                    //INFERIOR DERECHA
                    gameObject.transform.position = new Vector3((float)3.83,(float)1,(float)-5.03);
                break;
                default:
                    //Error
                break;
            }

        }
        public void setParedes(int piso){
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
            gameObject.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
            gameObject.transform.localScale = new Vector3((float)14.88152,(float)5,(float)1);
            gameObject.transform.position = new Vector3((float)-2.29,(float)2.58,(float)7.45);
            gameObject.transform.rotation = Quaternion.Euler((float)0,(float)0,(float)0);
            
            GameObject gameObject2 = GameObject.CreatePrimitive(PrimitiveType.Quad);
            gameObject2.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
            gameObject2.transform.localScale = new Vector3((float)14.88152,(float)5,(float)1);
            gameObject2.transform.position = new Vector3((float)5.16,(float)2.52,(float)0.02);
            gameObject2.transform.rotation = Quaternion.Euler((float)0,(float)90,(float)0);
            
        }

        public void setCuadro(int piso, int posicion){
            GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            gameObject.transform.parent = GameObject.Find("ImageTargetPiso"+(piso+1)).transform;
            gameObject.transform.localScale = new Vector3((float)2,(float)1,(float)0.5);
            
            if(posicion == 0)
            {
                gameObject.transform.position = new Vector3((float)-2.27,(float)2.65,(float)7.12);
                gameObject.transform.rotation = Quaternion.Euler((float)0,(float)0,(float)0);
            }
            else
            {
                gameObject.transform.position = new Vector3((float)4.9,(float)2.65,(float)0.73);
                gameObject.transform.rotation = Quaternion.Euler((float)0,(float)90,(float)0);
            }
            
        }
        public GestorPisos(){
            
        }
        // Update is called once per frame
        void Update()
        {

        }
    
        public void ClearChildren(int piso)
        {
            //Debug.Log(GameObject.Find("ImageTargetPiso"+(piso+1)).transform.childCount);
            int i = 0;
            
            //Array to hold all child obj
            GameObject[] allChildren = new GameObject[GameObject.Find("ImageTargetPiso"+(piso+1)).transform.childCount];

            //Find all child obj and store to that array
            foreach (Transform child in GameObject.Find("ImageTargetPiso"+(piso+1)).transform)
            {
                allChildren[i] = child.gameObject;
                i += 1;
            }

            //Now destroy them
            /*
            foreach (GameObject child in allChildren)
            {
                DestroyImmediate(child.gameObject);
            }
            */
            for(int j =0; j < allChildren.Length; j++){
                DestroyImmediate(allChildren[j].gameObject);
            }

            //Debug.Log(GameObject.Find("ImageTargetPiso"+(piso+1)).transform.childCount);
        }
    }
}