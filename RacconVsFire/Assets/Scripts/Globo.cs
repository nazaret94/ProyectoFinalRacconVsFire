using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class Globo : MonoBehaviour
{
    public GameObject GloboPrefab;
    private GameObject tmpGlobo;
    public GameObject Pistola;

    public float fuerzaGlobo;

    public void DisparaGlobo()
    {
        Pistola.SetActive(false);
        Invoke("DisparaG", 2f);
        Invoke("Activa", 4f);
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
    }
}
