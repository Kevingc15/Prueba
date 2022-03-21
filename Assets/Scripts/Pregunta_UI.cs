using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pregunta_UI : MonoBehaviour
{
    [SerializeField] private Text pregunta_texto;
    [SerializeField] private List<Respuesta_Button> button_lista;

    public void Construct(Pregunta pregunta, Action<Respuesta_Button> callback)
    {
        pregunta_texto.text = pregunta.texto;

        for(int i = 0; i < button_lista.Count; i++)
        {
            button_lista[i].Construct(pregunta.respuestas[i], callback);
        }
    }

}
