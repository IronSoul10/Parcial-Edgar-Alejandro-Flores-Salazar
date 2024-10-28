using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ContadorBajas : MonoBehaviour
{
    public TextMeshProUGUI contadorTexto;
    private int enemigosDestruidos = 0;

    void Start()
    {
        ActualizarContador();
    }

    public void EnemigoDestruido()
    {
        enemigosDestruidos++;
        ActualizarContador();
    }

    void ActualizarContador()
    {
        contadorTexto.text = ("") + enemigosDestruidos;
    }
}


