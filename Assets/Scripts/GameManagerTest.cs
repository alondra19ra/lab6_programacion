using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
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

        Player jugador = new Player("Heroe", 100, 20, 5);
        EnemigoAtacante enemigo = new EnemigoAtacante("Orco Guerrero", 80, 50);


        for (int turno = 1; turno <= 5; turno++)
        {
            Debug.Log("------ Turno " + turno + " ------");

            try
            {
                jugador.Atacar(enemigo);
            }
            catch (System.Exception ex)
            {
                Debug.LogWarning("Error al atacar: " + ex.Message);
            }

            enemigo.AtacarJugador();

            int danioAlJugador = Random.Range(5, 15);
            jugador.RecibirDanio(danioAlJugador);

            if (enemigo.Salud > 0 && jugador.Vida > 0)
            {
                continue;
            }
            Debug.Log("¡Fin del combate!");
            break;
        }
    }
}
