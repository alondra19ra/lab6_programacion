using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecibirDanio
{
    void RecibirDanio(int danio);
    void RecibirDaño(int danio, float multiplicador);
    void RecibirDaño(int danio);
}

