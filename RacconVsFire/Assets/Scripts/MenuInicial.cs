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
    }
    public void CargaMenuInicial()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
    public void CaragaNivel2()
    {
    
        SceneManager.LoadScene("Nivel 2");
    }
    public void CaragaNivel3()
    {
      
        SceneManager.LoadScene("Nivel 3");
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
