using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : Item
{
    private int dano;

    public Espada(string nombre, int dano) : base(nombre)
    {
        this.dano = dano;
    }

    public override void Usar()
    {
        Debug.Log("Usaste la espada " + nombre + ". Causas " + dano + " de daño.");
    }
}
