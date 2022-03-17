using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool estadoJuego;
    public AudioSource fondo;

    void Start()
    {
        estadoJuego = true;
    }
    public void EstadoDePausa()
    {
        estadoJuego = !estadoJuego;
        if (estadoJuego)
        {
            Time.timeScale = 1f;
            fondo.Play();
        }else
        {
           Time.timeScale = 0f;
           fondo.Pause();   
        }
    }


 }
