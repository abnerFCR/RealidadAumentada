using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

namespace Espacios
{
    

    public class Pisos : MonoBehaviour
    {

        public static Espacio[] espacios= new Espacio[3]; 
        public static bool primera = true;
        // Start is called before the first frame update
        void Start()
        {
            
            if(primera){
                for (int i = 0; i < 3; i++)
                {
                    Espacio espacio = new Espacio(false, 0, 0, 0, 0, 0);
                    Pisos.espacios[i] = espacio;
                }
                primera= !primera;
            }
            
        }

        public void CrearEspacio(){
            Dropdown ddlPiso = GameObject.Find("ddlPiso").GetComponent<Dropdown>();
            Dropdown ddlEscritorio = GameObject.Find("ddlEscritorio").GetComponent<Dropdown>();
            Dropdown ddlSilla = GameObject.Find("ddlSilla").GetComponent<Dropdown>();
            Dropdown ddlIluminacion = GameObject.Find("ddlIluminacion").GetComponent<Dropdown>();
            Dropdown ddlCuadro = GameObject.Find("ddlCuadro").GetComponent<Dropdown>();
        
            
            if(Pisos.espacios[ddlPiso.value].getEstado())
            {
                //El piso ya esta ocupado
                Pisos.EscribirEnBitacora("ERROR","Se intento crear un espacio sobre un piso ocupado.");
                SceneManager.LoadScene("PisoOcupado");
            }
            else if(ddlSilla.value == ddlEscritorio.value)
            {
                Pisos.EscribirEnBitacora("ERROR","Se intento colocar la silla y el escritorio en el mismo lugar.");
                SceneManager.LoadScene("MismoLugar");
                //la silla y el escritorio ocupan el mismo lugar
            }
            else
            {
                Pisos.espacios[ddlPiso.value].setEstado(true);
                Pisos.espacios[ddlPiso.value].setIluminacion(ddlIluminacion.value);
                Pisos.espacios[ddlPiso.value].setPiso(ddlPiso.value);
                Pisos.espacios[ddlPiso.value].setPosicionCuadro(ddlCuadro.value);
                Pisos.espacios[ddlPiso.value].setPosicionEscritorio(ddlEscritorio.value);
                Pisos.espacios[ddlPiso.value].setPosicionSilla(ddlSilla.value);
                Pisos.EscribirEnBitacora("ACCION","Se creo creo el espacio "+(ddlPiso.value+1)+" satisfactoriamente");
                SceneManager.LoadScene("CreadoExito");
            }
            
        }

        public void EliminarEspacio()
        {
            Dropdown ddlPiso = GameObject.Find("ddlEliminar").GetComponent<Dropdown>();
            
            if(Pisos.espacios[ddlPiso.value].getEstado())
            {
                Espacio espacio = new Espacio(false,0,0,0,0,0);
                Pisos.espacios[ddlPiso.value] = espacio;
                Pisos.EscribirEnBitacora("ACCION","Se elimino el espacio "+(ddlPiso.value+1)+" de forma correcta.");
                SceneManager.LoadScene("EliminadoExito");
            }
            else
            {
                Pisos.EscribirEnBitacora("ERROR", "Se intento liberar un espacio que ya estaba disponible.");
                SceneManager.LoadScene("ErrorEliminar");
            }
        }

        public string ObtenerEstado(){
            Dropdown ddlPiso = GameObject.Find("ddlEliminar").GetComponent<Dropdown>();
            
            if(Pisos.espacios[ddlPiso.value].getEstado())
            {
                return "Ocupado";
            }
            return "Libre";
        }


        public void VisualizarEspacio()
        {
            Pisos.EscribirEnBitacora("ACCION", "Se ingreso al modo visualizacion.");
            SceneManager.LoadScene("RealidadAumentada1");
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public static void EscribirEnBitacora(string tipo, string mensaje){
            string ruta = Application.dataPath + "/bitacora_201603095_201603189.txt";
            if(!File.Exists(ruta))
            {
                File.WriteAllText(ruta, "Bitacora Proyecto \n\n");
            }

            File.AppendAllText(ruta, "["+tipo+"] "+mensaje+"\n");
        }

    }
}