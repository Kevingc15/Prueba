using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Categoria : MonoBehaviour
{
    private int id;
    private string _nombre;
    private int _nivel;

    public Categoria(int id, string nombre, int nivel)
    {
        this.id = id;
        this._nombre = nombre;
        this._nivel = nivel;
    }

    public string nombre { get { return _nombre;    }  set  { _nombre = value;  } }

    public int nivel { get { return _nivel; } set { _nivel = value; } }
}
