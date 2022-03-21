using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private int id;
    private string nombre;
    private int puntos;

    public Jugador(int id, string nombre, int puntos)
    {
        this.id = id;
        this.nombre = nombre;
        this.puntos = puntos;
    }
}
