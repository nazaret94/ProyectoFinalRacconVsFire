using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class VidasMapache : MonoBehaviour
{

    public GameObject panelGameOver;
    public GameObject panelWin;

    public GameObject []vida;
    int vidaMapache = 5;

    //Subscripcion a eventos
    private void OnEnable()
    {
        RocoCollider.SumaVida += Agregavida;
        RocoCollider.RestaVida += Eliminavida;
        Arboles.PanelWin += Win;
        Arboles.PanelGameOver += GameOver;
    }

    private void OnDisable()
    {
        RocoCollider.SumaVida -= Agregavida;
        RocoCollider.RestaVida -= Eliminavida;
        Arboles.PanelWin -= Win;
        Arboles.PanelGameOver -= GameOver;
    }

    public void Agregavida()
    {
        vidaMapache += 1;
        switch (vidaMapache)
        {
            case 5:
                vida[4].SetActive(true);
                break;
            case 4:
                vida[3].SetActive(true);
                break;
            case 3:
                vida[2].SetActive(true);
                break;
            case 2:
                vida[1].SetActive(true);
                break;
            case 1:
                vida[0].SetActive(true);
                break;
        }
    }

    public void Eliminavida()
    {
        vidaMapache -= 1;
        switch (vidaMapache)
        {
            case 4:
                vida[4].SetActive(false);
                break;
            case 3:
                vida[3].SetActive(false);
                break;
            case 2:
                vida[2].SetActive(false);
                break;
            case 1:
                vida[1].SetActive(false);
                break;
            case 0:
                vida[0].SetActive(false);
                GameOver();
                break;
        }
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
  
    }

    public void Win()
    {
        panelWin.SetActive(true);

    }

}
