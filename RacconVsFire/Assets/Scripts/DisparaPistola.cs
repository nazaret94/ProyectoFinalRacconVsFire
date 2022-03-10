using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparaPistola : MonoBehaviour
{ 
    public GameObject gotaDeAgua;
    public float fuerzaDelAgua;
    private GameObject tmpAgua;

  public void Disparagota()
    {
        Debug.Log("gota");
        Invoke("Dispara", 1f);
    }
            
   void Dispara()
    {
  
       tmpAgua = Instantiate(gotaDeAgua, transform.position, Quaternion.identity);
       tmpAgua.transform.forward = transform.forward;
       tmpAgua.GetComponent<Rigidbody>().AddForce(transform.forward * fuerzaDelAgua, ForceMode.Impulse);
    }
   
}
