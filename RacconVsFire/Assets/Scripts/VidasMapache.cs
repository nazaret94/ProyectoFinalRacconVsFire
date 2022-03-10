using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasMapache : MonoBehaviour
{
    public GameObject []vida;
    int vidaMapache = 5;


    public void Agragavida()
    {
        vidaMapache =+ 1;
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
        vidaMapache = -1;
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
                break;
        }
    }
}
