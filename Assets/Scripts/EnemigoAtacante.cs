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

    #region M�todos
    public void AtacarJugador()
    {
        if (Time.time - tiempoUltimoAtaque >= intervaloEntreAtaques)
        {
            // El enemigo realiza el ataque
            UsarHabilidad(); // Usa la habilidad de atacar
            tiempoUltimoAtaque = Time.time; // Actualiza el tiempo del �ltimo ataque
            Debug.Log(Nombre + " ha atacado al jugador.");
        }
        else
        {
            Debug.Log(Nombre + " est� esperando para atacar.");
        }
    }
    public void AtacarJugador(int danioExtra)
    {
        if (Time.time - tiempoUltimoAtaque >= intervaloEntreAtaques)
        {
            // Aplica el ataque normal m�s un da�o extra
            UsarHabilidad();
            Debug.Log(Nombre + " ha atacado al jugador con da�o extra de " + danioExtra);
            tiempoUltimoAtaque = Time.time;
        }
    }

    // M�todo para realizar un ataque especial
    public void AtacarEspecial()
    {
        Debug.Log(Nombre + " est� realizando un ataque especial!");
        UsarHabilidad(); // Usa la habilidad de atacar
        Debug.Log(Nombre + " ha hecho un ataque especial.");
    }

    // M�todo para hacer que el enemigo se defienda
    public void Defender()
    {
        // Logica de defensa, por ejemplo, reducir el da�o recibido temporalmente
        Debug.Log(Nombre + " est� defendiendo.");
    }
    #endregion
}


