using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Solis Torres Mariana Nazaret

public class NumeroGotas : MonoBehaviour
{
    public delegate void Anima();
    public static event Anima AnimaG;
    public Image BotonGlobo;

    int Gotas = 0;
    int contGotas = 0;

    public GameObject GloboPrefab;
    private GameObject tmpGlobo;
    public GameObject Pistola;
    public GameObject globo;

    public float fuerzaGlobo;


    //Subscripcion a eventos
    private void OnEnable()
    {
        RocoCollider.SumaGota += AgregaGota;
        Globo.RestaGlobo += QuitarGota;
    }
   private void OnDisable()
    {
        RocoCollider.SumaGota -= AgregaGota;
        Globo.RestaGlobo -= QuitarGota;
    }

    public void AgregaGota()
    {
        contGotas += 1;
        if (Gotas < 4)
        {
            Gotas += 1;
            BotonGlobo.fillAmount += .25f;
        }
    }

    public void QuitarGota()
    {
        if(Gotas != 0)
        {
            BotonGlobo.fillAmount -= .25f;
            globo.SetActive(true);
            Pistola.SetActive(false);
            AnimaG();
            Gotas -= 1;
            Invoke("DisparaG", 1f);
            Invoke("Activa", 4f);
        }     
    }

    void DisparaG()
    {
        tmpGlobo = Instantiate(GloboPrefab, transform.position, Quaternion.identity);
        tmpGlobo.transform.forward = transform.forward;
        tmpGlobo.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaGlobo, ForceMode.Impulse);
    }

    void Activa()
    {
        Pistola.SetActive(true);
        globo.SetActive(false);
    }


}
