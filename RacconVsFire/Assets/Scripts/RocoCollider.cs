using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class RocoCollider : MonoBehaviour
{
    //Event Vida del Mapache
    public delegate void Vida();
    public static event Vida SumaVida;
    public static event Vida RestaVida;

    public delegate void Gota();
    public static event Gota SumaGota;

    private float attackMF = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Flama")
        {
           if(RestaVida != null)
            {
                RestaVida();
                other.gameObject.SetActive(false);
            } 
        }

        if(other.transform.tag == "corazon")
        {
            if(SumaVida!= null)
            {
                SumaVida();
                other.gameObject.SetActive(false);
            }
        }

        if(other.transform.tag == "Gota")
        {
            SumaGota();
            other.gameObject.SetActive(false);
        }
         if (other.transform.tag == "MegaFlama")
        {
            if (attackMF == 20)
            {
             RestaVida();
             attackMF = 0;
            }
         
            if (attackMF < 20)
            {
            attackMF += 1;
            }

        }
    }
  
}
