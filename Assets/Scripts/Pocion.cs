using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pocion : Item
{
    private int cantidadCuracion;

    public Pocion(string nombre, int cantidadCuracion) : base(nombre)
    {
        this.cantidadCuracion = cantidadCuracion;
    }

    public override void Usar()
    {
        Debug.Log("Usaste la poci�n " + nombre + ". Recuperas " + cantidadCuracion + " de salud.");
    }
}
