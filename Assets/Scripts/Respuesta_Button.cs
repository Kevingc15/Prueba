using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Respuesta_Button : MonoBehaviour
{
    private Text texto;
    private Button button;
    public Respuesta respuesta { get; set; }
    private Color color_original;
    private Image image;

    private void Awake()
    {
        button = GetComponent<Button>();
        texto = transform.GetChild(0).GetComponent<Text>();
        image = GetComponent<Image>();
        color_original = image.color;
    }

    public void Construct(Respuesta respuesta, Action<Respuesta_Button> callback)
    {
        //ERROR, AL SELECCIONAR LA RESPUESTA CORRECTA NO SE DESELECCIONA
        //NO CAMBIA DE COLOR A COLOR CORRECTO O INCORRECTO
        button.onClick.RemoveAllListeners();
        button.enabled = true;
        texto.text = respuesta.texto;
        this.respuesta = respuesta;
        image.color = color_original;
        button.onClick.AddListener(delegate {callback(this);});

    }

    public void SetColor(Color color)
    {
        button.image.color = color;
    }

}
