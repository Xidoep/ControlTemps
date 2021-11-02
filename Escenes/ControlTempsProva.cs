using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTempsProva : MonoBehaviour
{
    [ContextMenu("Prova1")]
    void Prova1()
    {
        ControlTemps.Temps(0, 1f);
    }
    [ContextMenu("Prova2")]
    void Prova2()
    {
        ControlTemps.Temps(1, 0.5f);
    }
    [ContextMenu("Prova3")]
    void Prova3()
    {
        ControlTemps.Temps(1);
    }
    [ContextMenu("Prova4")]
    void Prova4()
    {
        ControlTemps.Pausar(2);
    }
}
