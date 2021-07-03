using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Espacios
{
    public class navegacion : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void LlevarCrear()
        {
            Pisos.EscribirEnBitacora("ACCION", "Se ingreso al menu de Crear");
            SceneManager.LoadScene("Crear");
        }
        public void LlevarEliminar()
        {
            Pisos.EscribirEnBitacora("ACCION", "Se ingreso al menu de eliminar");
            SceneManager.LoadScene("EliminarEspacio");
        }
        public void LlevarVisualizar()
        {
            Pisos.EscribirEnBitacora("ACCION", "Se ingreso al modo visualizacion.");
            SceneManager.LoadScene("RealidadAumentada1");
        }
        public void IrMenuPrincipal()
        {
            Pisos.EscribirEnBitacora("ACCION", "Se ingreso al menu principal");
            SceneManager.LoadScene("Menuprincipal");
        }
    }
}
