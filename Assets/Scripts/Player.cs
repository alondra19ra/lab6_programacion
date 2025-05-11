using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
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
        if (durabilidad <= 0)
            throw new System.Exception("El arma est� rota y no puedes atacar");

        int da�ioAleatorio = Random.Range(da�ioBase - 2, da�ioBase + 3);
        enemigo.RecibirDanio(da�ioAleatorio);
        durabilidad--;
        Debug.Log(nombre + " ataco a " + enemigo.Nombre + " causando " + da�ioAleatorio + " de da�o. Durabilidad restante: " + durabilidad);
    }

    public void RecibirDanio(int danio)
    {
        vida -= danio;
        Debug.Log(nombre + " recibi� " + danio + " de da�o. Vida restante: " + vida);
        if(vida <= 0)
            Debug.Log(nombre + " ha muerto.");
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
