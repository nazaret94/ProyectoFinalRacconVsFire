using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Solis Torres Mariana Nazaret

public class MenuInicial : MonoBehaviour
{

    public void CargaNivel1()
    {
     SceneManager.LoadScene("Nivel 1");
        Debug.Log("Carga Nivel 1");
    }
    public void ActivarPantalla(GameObject pantalla)
    {
        pantalla.SetActive(true);
    }

    public void DesactivarPantalla(GameObject pantalla)
    {
        pantalla.SetActive(false);
    }

    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com");
    }
}
