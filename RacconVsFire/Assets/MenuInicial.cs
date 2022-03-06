using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
  
    public void CargaNivel1()
    {
     SceneManager.LoadScene("Nivel 1");
        Debug.Log("Carga Nivel 1");
    } 
}
