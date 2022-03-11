using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class Fuego : MonoBehaviour
{
    public GameObject fuegoPrefab;
    public GameObject Arbol;
    public float fuerzaFuego;
 
    private void OnTriggerEnter(Collider other)
    {
        if( other.transform.tag == "Roco")
        {
        StartCoroutine("CaeFuego");
        }   
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Roco")
        {
            StopCoroutine("CaeFuego");
        }
    }

    IEnumerator CaeFuego()
    {
       yield return new WaitForSeconds(3f);
       Instantiate(fuegoPrefab,Arbol.transform.position, Quaternion.identity);
       fuegoPrefab.transform.up = transform.up;
       fuegoPrefab.GetComponent<Rigidbody>().AddForce(transform.up* fuerzaFuego,ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        StartCoroutine("CaeFuego");
    }

}