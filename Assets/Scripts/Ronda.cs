using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ronda : MonoBehaviour
{

    [SerializeField] private List<Pregunta> _preguntas;
    public int _puntos;

    public Ronda(List<Pregunta> preguntas, int puntos)
    {
        this._preguntas = preguntas;
        this._puntos = puntos;
    }
    public List<Pregunta> preguntas { get { return _preguntas; } set { _preguntas = value; } }
    public int puntos { get { return _puntos; } set { _puntos = value; } }

}
