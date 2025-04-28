using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtacante : Enemigo
{
    #region Private
    private float tiempoUltimoAtaque;
    private float intervaloEntreAtaques = 2f; // Tiempo en segundos entre cada ataque
    #endregion

    #region Constructor
    public EnemigoAtacante(string _nombre, int _salud, int _scoreAlMorir)
        : base(_nombre, _salud, _scoreAlMorir, new Atacar())
    {
        tiempoUltimoAtaque = Time.time;
        Debug.Log("Enemigo Atacante " + _nombre + " creado.");
    }
    #endregion

    #region Métodos
    public void AtacarJugador()
    {
        if (Time.time - tiempoUltimoAtaque >= intervaloEntreAtaques)
        {
            // El enemigo realiza el ataque
            UsarHabilidad(); // Usa la habilidad de atacar
            tiempoUltimoAtaque = Time.time; // Actualiza el tiempo del último ataque
            Debug.Log(Nombre + " ha atacado al jugador.");
        }
        else
        {
            Debug.Log(Nombre + " está esperando para atacar.");
        }
    }
    public void AtacarJugador(int danioExtra)
    {
        if (Time.time - tiempoUltimoAtaque >= intervaloEntreAtaques)
        {
            // Aplica el ataque normal más un daño extra
            UsarHabilidad();
            Debug.Log(Nombre + " ha atacado al jugador con daño extra de " + danioExtra);
            tiempoUltimoAtaque = Time.time;
        }
    }

    // Método para realizar un ataque especial
    public void AtacarEspecial()
    {
        Debug.Log(Nombre + " está realizando un ataque especial!");
        UsarHabilidad(); // Usa la habilidad de atacar
        Debug.Log(Nombre + " ha hecho un ataque especial.");
    }

    // Método para hacer que el enemigo se defienda
    public void Defender()
    {
        // Logica de defensa, por ejemplo, reducir el daño recibido temporalmente
        Debug.Log(Nombre + " está defendiendo.");
    }
    #endregion
}


