using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
    void Start()
    {
        // Creamos enemigos con habilidades espec�ficas
        Enemigo enemigo1 = new EnemigoAtacante("Enemigo Orco", 100, 50);
        Enemigo enemigo2 = new EnemigoAtacante("Enemigo Curador", 80, 30);

        // Usamos las habilidades
        enemigo1.UsarHabilidad(); // El enemigo ataca
        enemigo2.UsarHabilidad(); // El enemigo se cura

        // Recibimos da�o y morimos
        enemigo1.RecibirDanio(110); // El enemigo atacar� y luego morir�
        enemigo1.RecibirDa�o(20, 1.5f);
        enemigo2.RecibirDanio(80);
        enemigo2.RecibirDa�o(10, 2.5f);// El enemigo curador morir� despu�s de recibir da�o
    }
}
