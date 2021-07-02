using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("Crear");
    }
    public void LlevarEliminar()
    {
        SceneManager.LoadScene("EliminarEspacio");
    }
    public void LlevarVisualizar()
    {
        SceneManager.LoadScene("RealidadAumentada1");
    }
    public void IrMenuPrincipal()
    {
        SceneManager.LoadScene("Menuprincipal");
    }
}

