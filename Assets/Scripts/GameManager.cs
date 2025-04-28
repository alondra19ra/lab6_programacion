using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score = 0;

    public static void AumentarScore(int cantidad)
    {
        score += cantidad;
        Debug.Log("Nuevo score: " + score);
    }
}

