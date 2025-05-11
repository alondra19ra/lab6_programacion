using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : IItem
{
    protected string nombre;

    public Item(string nombre)
    {
        this.nombre = nombre;
    }

    public abstract void Usar();
}

