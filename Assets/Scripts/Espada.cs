using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Espada : IItem
{
    public string Nombre;
    public int DanioBase;
    public int Durabilidad;

    public Espada(string nombre, int danio, int durabilidad = 5)
    {
        Nombre = nombre;
        DanioBase = danio;
        Durabilidad = durabilidad;
    }

    public int UsarEspada()
    {
        if (Durabilidad <= 0)
            throw new Exception("El arma ya no tiene durabilidad.");

        Durabilidad -= UnityEngine.Random.Range(1, 3);
        return UnityEngine.Random.Range(1, DanioBase + 1);
    }

    public void Usar()
    {
        Debug.Log(Nombre + " usada " + "durabilidad: " + Durabilidad);
    }
}
