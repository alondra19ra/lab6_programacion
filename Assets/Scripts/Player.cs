using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string nombre;
    private int vida;
    private int dañioBase;
    private int durabilidad;

    private string Nombre => nombre;
    public int Vida => vida;
    private int Daño => dañioBase;
    private int Durabilidad => durabilidad;

    public Player(string nombre, int vida, int dañioBase, int durabilidad)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.dañioBase = dañioBase;
        this.durabilidad = durabilidad;
        Debug.Log("Se ha creado el jugador: " + nombre + " con " + vida + " de vida.");
    }

    public void Atacar(Enemigo enemigo)
    {
        if (durabilidad <= 0)
            throw new System.Exception("El arma está rota y no puedes atacar");

        int dañioAleatorio = Random.Range(dañioBase - 2, dañioBase + 3);
        enemigo.RecibirDanio(dañioAleatorio);
        durabilidad--;
        Debug.Log(nombre + " ataco a " + enemigo.Nombre + " causando " + dañioAleatorio + " de daño. Durabilidad restante: " + durabilidad);
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;
        Debug.Log(nombre + " recibió " + danio + " de daño. Vida restante: " + vida);
        if(vida <= 0)
            Debug.Log(nombre + " ha muerto.");
    }

    public void RecibirDaño(int danio, float multiplicador)
    {
        int total = (int)(danio * multiplicador);
        RecibirDanio(total);
    }

    public void RecibirDaño(int danio)
    {
        RecibirDanio(danio);
    }

}
