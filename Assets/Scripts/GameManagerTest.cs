using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManagerTest : MonoBehaviour
{
    private Player jugador;
    private EnemigoAtacante enemigo;

    void Start()
    {
        /*Enemigo enemigo1 = new EnemigoAtacante("Orco Guerrero", 100, 50);
        Enemigo enemigo2 = new Enemigo("Hechicero", 80, 30, new Curar());

        IItem pocion = new Pocion("Poción de Vida", 30);
        IItem espada = new Espada("Espada de Hierro", 15);

        pocion.Usar();
        espada.Usar();

        enemigo1.UsarHabilidad();
        enemigo2.UsarHabilidad();

        enemigo1.RecibirDaño(40);
        enemigo2.RecibirDaño(25, 2f);*/

        jugador = new Player("Heroe", 100, 20, 5);
        enemigo = new EnemigoAtacante("Orco Guerrero", 80, 50);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("=== Combate iniciado (tecla A) ===");
            try
            {
                jugador.Atacar(enemigo);

                int danioEnemigo = UnityEngine.Random.Range(10, 20);
                jugador.RecibirDanio(danioEnemigo);

                enemigo.AtacarJugador();
            }

            catch(System.Exception ex)
            {
                Debug.Log("Peligro" + ex.Message);
            }
        }
    }
}
