using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IRecibirDanio
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
        if(vida <= 0)
            throw new System.Exception(nombre + " ya está muerto y no puede atacar");

        if (durabilidad <= 0)
            throw new System.Exception("El arma está rota y no puedes atacar");

        int dañioAleatorio = Random.Range(dañioBase - 5, dañioBase + 5);
        int desgaste = Random.Range(1, 3);

        enemigo.RecibirDanio(dañioAleatorio);
        durabilidad -= desgaste;
        Debug.Log(nombre + " ataco a " + enemigo.Nombre + " causando " + dañioAleatorio + " de daño. Durabilidad restante: " + durabilidad);
        
        if (durabilidad <= 0)
            throw new System.Exception("El arma se rompió tras el ataque.");
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;
        Debug.Log(nombre + " recibió " + danio + " de daño. Vida restante: " + vida);
        if(vida <= 0)
            throw new System.Exception(nombre + " ha muerto.");
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
