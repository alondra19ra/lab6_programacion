using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTest : MonoBehaviour
{
    void Start()
    {
        Enemigo enemigo1 = new EnemigoAtacante("Orco Guerrero", 100, 50);
        Enemigo enemigo2 = new Enemigo("Hechicero", 80, 30, new Curar());

        IItem pocion = new Pocion("Poción de Vida", 30);
        IItem espada = new Espada("Espada de Hierro", 15);

        pocion.Usar();
        espada.Usar();

        enemigo1.UsarHabilidad();
        enemigo2.UsarHabilidad();

        enemigo1.RecibirDaño(40);
        enemigo2.RecibirDaño(25, 2f);
    }
}
