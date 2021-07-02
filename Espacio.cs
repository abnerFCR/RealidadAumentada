using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Espacios
{
    

public class Espacio
{

    private bool estado;
    private int piso;
    private int iluminacion;
    private int posicionEscritorio;
    private int posicionSilla;
    private int posicionCuadro;

    public Espacio(bool estado, int piso, int iluminacion, int posicionEscritorio, int posicionSilla, int posicionCuadro)
    {
        this.estado = estado;
        this.piso = piso;
        this.posicionEscritorio = posicionEscritorio;
        this.iluminacion = iluminacion;
        this.posicionSilla = posicionSilla;
        this.posicionCuadro = posicionCuadro;
    }

    public bool getEstado()
    {
        return this.estado;
    }
    public int getPosicionSilla()
    {
        return this.posicionSilla;
    }
    public int getPosicionEscritorio()
    {
        return this.posicionEscritorio;
    }
    public int getIluminacion()
    {
        return this.iluminacion;
    }
    public int getPiso()
    {
        return this.piso;
    }
    public int getPosicionCuadro()
    {
        return this.posicionCuadro;
    }


    public void setEstado(bool estado)
    {
        this.estado = estado;
    }
    public void setPosicionSilla(int posicionSilla)
    {
        this.posicionSilla = posicionSilla;
    }
    public void setPosicionEscritorio(int posicionEscritorio)
    {
        this.posicionEscritorio = posicionEscritorio;
    }
    public void setIluminacion(int iluminacion)
    {
        this.iluminacion = iluminacion;
    }
    public void setPiso(int piso)
    {
        this.piso = piso;
    }
    public void setPosicionCuadro(int posicionCuadro)
    {
        this.posicionCuadro = posicionCuadro;
    }

}
}