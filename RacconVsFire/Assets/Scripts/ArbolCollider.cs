using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class ArbolCollider : MonoBehaviour
{
    //Evento
    public delegate void ApagaF();
    public static event ApagaF ApagaA;
    public GameObject origenFuego;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Agua")
        {
            this.GetComponentInParent<Animator>().SetBool("ArbolF", false);
            if(ApagaA != null)
            {
                ApagaA();
            }
            origenFuego.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
