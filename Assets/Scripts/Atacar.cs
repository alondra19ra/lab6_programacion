using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : IHabilidad
{
    public void UsarHabilidad()
    {
        Debug.Log("¡El enemigo está atacando!");
    }
}

