using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IRecibirDanio
{
    private string nombre;
    private int vida;
    private int da�ioBase;
    private int durabilidad;

    private string Nombre => nombre;
    public int Vida => vida;
    private int Da�o => da�ioBase;
    private int Durabilidad => durabilidad;

    public Player(string nombre, int vida, int da�ioBase, int durabilidad)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.da�ioBase = da�ioBase;
        this.durabilidad = durabilidad;
        Debug.Log("Se ha creado el jugador: " + nombre + " con " + vida + " de vida.");
    }

    public void Atacar(Enemigo enemigo)
    {
        if(vida <= 0)
            throw new System.Exception(nombre + " ya est� muerto y no puede atacar");

        if (durabilidad <= 0)
            throw new System.Exception("El arma est� rota y no puedes atacar");

        int da�ioAleatorio = Random.Range(da�ioBase - 5, da�ioBase + 5);
        int desgaste = Random.Range(1, 3);

        enemigo.RecibirDanio(da�ioAleatorio);
        durabilidad -= desgaste;
        Debug.Log(nombre + " ataco a " + enemigo.Nombre + " causando " + da�ioAleatorio + " de da�o. Durabilidad restante: " + durabilidad);
        
        if (durabilidad <= 0)
            throw new System.Exception("El arma se rompi� tras el ataque.");
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;
        Debug.Log(nombre + " recibi� " + danio + " de da�o. Vida restante: " + vida);
        if(vida <= 0)
            throw new System.Exception(nombre + " ha muerto.");
    }

    public void RecibirDa�o(int danio, float multiplicador)
    {
        int total = (int)(danio * multiplicador);
        RecibirDanio(total);
    }

    public void RecibirDa�o(int danio)
    {
        RecibirDanio(danio);
    }

}
