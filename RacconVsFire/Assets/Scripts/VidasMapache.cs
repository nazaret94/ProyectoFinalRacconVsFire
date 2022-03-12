using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Solis Torres Mariana Nazaret

public class VidasMapache : MonoBehaviour
{
    public Image BotonCorazon;

    public GameObject panelGameOver;
    public GameObject panelWin;

    public GameObject []vida;
    int vidaMapache = 5;
    int numeroCorazones = 0;

    
    //Subscripcion a eventos
    private void OnEnable()
    {
        RocoCollider.SumaVida += ConteoCorazon;
        RocoCollider.RestaVida += Eliminavida;
        Arboles.PanelWin += Win;
        Arboles.PanelGameOver += GameOver;
    }

    private void OnDisable()
    {
        RocoCollider.SumaVida -= ConteoCorazon;
        RocoCollider.RestaVida -= Eliminavida;
        Arboles.PanelWin -= Win;
        Arboles.PanelGameOver -= GameOver;
    }

    public void Agregavida()
    {
        
        if (vidaMapache < 5)
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
    }

    public void ConteoCorazon()
    {
        if (numeroCorazones < 2)
        {
        numeroCorazones +=  1;
        BotonCorazon.fillAmount += 0.5f;
        }
    }

    public void AumentaCorazon()
    {
        if(numeroCorazones==1 || numeroCorazones == 2)
        {
            Debug.Log("boton" + BotonCorazon.fillAmount);
            numeroCorazones -= 1;
            BotonCorazon.fillAmount -= .5f;
            Agregavida();
        }
    }
    public void Eliminavida()
    {
        if(vidaMapache > 0)
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
