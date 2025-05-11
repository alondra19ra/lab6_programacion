using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : IRecibirDanio, IDropItem
{
    #region Private
    private string nombre;
    private int salud;
    private int scoreAlMorir;
    private IHabilidad habilidad;
    #endregion

    #region Getters
    public string Nombre => nombre;
    public int Salud => salud;
    public int ScoreAlMorir => scoreAlMorir;
    #endregion

    #region Constructor
    public Enemigo(string _nombre, int _salud, int _scoreAlMorir, IHabilidad _habilidad)
    {
        nombre = _nombre;
        salud = _salud;
        scoreAlMorir = _scoreAlMorir;
        habilidad = _habilidad;
        Debug.Log("Se ha creado el enemigo: " + nombre + " con " + salud + " de salud y " + scoreAlMorir + " de score al morir.");
    }
    public Enemigo(string _nombre, int _salud, int _scoreAlMorir)
        : this(_nombre, _salud, _scoreAlMorir, new Atacar()) { }
    #endregion

    #region Métodos
    public void RecibirDanio(int danio)
    {
        salud -= danio;
        Debug.Log(nombre + " ha recibido " + danio + " de daño. Salud restante: " + salud);
        if (salud <= 0)
        {
            Morir();
            throw new System.Exception(nombre + " ha muerto.");
        }
    }
    public void RecibirDaño(int danio, float multiplicador)
    {
        int danoTotal = (int)(danio * multiplicador); // Aplicamos el multiplicador
        salud -= danoTotal;
        Debug.Log(nombre + " ha recibido " + danoTotal + " de daño (con multiplicador). Salud restante: " + salud);
        if (salud <= 0)
        {
            Morir();
        }
    }
    public void RecibirDaño(int danio) 
    {
        RecibirDanio(danio);
    }

    public void Morir()
    {
        Debug.Log(nombre + " ha muerto.");
        GameManager.AumentarScore(scoreAlMorir);
    }

    public void DropearItem()
    {
        Debug.Log(nombre + " ha soltado un item.");
    }

    public void UsarHabilidad()
    {
        habilidad.UsarHabilidad();
    }
    #endregion
}

