using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private float espera = 0.5f;
    private Preguntas_DB preguntas_db;
    private Pregunta_UI preguntas_ui;

    public void Start()
    {
        preguntas_db = GameObject.FindObjectOfType<Preguntas_DB>();
        preguntas_ui = GameObject.FindObjectOfType<Pregunta_UI>();
        NextPregunta();
    }

    public void NextPregunta()
    {
        
        preguntas_ui.Construct(preguntas_db.GetPregunta(), SendRespuesta);
    }

    private void SendRespuesta(Respuesta_Button respuesta_btn)
    {
        StartCoroutine(SendRespuestaRoutine(respuesta_btn));
    }

    private IEnumerator SendRespuestaRoutine(Respuesta_Button respuesta_btn)
    {
        if (respuesta_btn.respuesta.correcta)
        {
            respuesta_btn.SetColor(Color.green);

        }
        else
        {
            respuesta_btn.SetColor(Color.red);  
        }

        yield return new WaitForSeconds(espera);
        if (respuesta_btn.respuesta.correcta)
        {
            respuesta_btn.gameObject.SetActive(false);
            respuesta_btn.gameObject.SetActive(true);
            NextPregunta();
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
