using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class Globo : MonoBehaviour
{
    //Evento
    public delegate void EGlobo();
    public static event EGlobo RestaGlobo;


    public void DisparaGlobo()
    {
        RestaGlobo();
    }
}
