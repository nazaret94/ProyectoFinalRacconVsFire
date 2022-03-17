using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class DisparaPistola : MonoBehaviour
{ 
    public GameObject gotaDeAgua;
    private GameObject tmpAgua;

    public float fuerzaDelAgua;

  public void Disparagota()
    {
        Invoke("Dispara", 1f);
    }
            
   void Dispara()
    {
       tmpAgua = Instantiate(gotaDeAgua, transform.position, Quaternion.identity);
       tmpAgua.transform.forward = transform.forward;
       tmpAgua.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaDelAgua, ForceMode.Impulse);
    }
   
}
