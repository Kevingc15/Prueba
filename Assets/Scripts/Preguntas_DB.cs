using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;



public class Preguntas_DB : MonoBehaviour
{
    [Header("json")]
    string filePath;
    string jsonString;

    [System.Serializable]
    public class ListPreguntas
    {
        public List<Pregunta> preguntas;
    }

    [SerializeField] private List<Pregunta> lista_preguntas;
    private List<Pregunta> backup;
    private int nivel = 1;
    public void Awake()
    {
        backup = lista_preguntas.ToList();
        TextAsset txtAssets = (TextAsset)Resources.Load("preguntas");
        filePath = Application.dataPath + "/Resources/preguntas.json";
        CrearPreguntas(nivel);
    }

    public Pregunta GetPregunta(bool remove = true)
    {
        if(lista_preguntas.Count == 0)
        {
            CrearPreguntas(nivel+1);
        }

        int i = Random.Range(0, lista_preguntas.Count);
        Pregunta pregunta = lista_preguntas[i];
        if (remove)
        {
            lista_preguntas.RemoveAt(i);
        }

        return pregunta;
    }

    private void CrearPreguntas(int nivel)
    {
        string jsonString = File.ReadAllText(filePath);
        ListPreguntas preguntas = JsonUtility.FromJson<ListPreguntas>(jsonString);

        for(int i=0; i< preguntas.preguntas.Count; i++)
        {
            if(preguntas.preguntas[i].nivel == nivel)
            {
                lista_preguntas.Add(preguntas.preguntas[i]);
            }
        }
    }

}


