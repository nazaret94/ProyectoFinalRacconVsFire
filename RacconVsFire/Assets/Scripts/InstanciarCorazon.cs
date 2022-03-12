using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class InstanciarCorazon : MonoBehaviour
{
    public GameObject corazon;
    public Vector2 rango;
    public int numCorazon;
    private GameObject tmpCora;

    void Start()
    {
        for (int i = 0; i <= numCorazon; i++)
        {

            tmpCora = Instantiate(corazon, transform.position + new Vector3(Random.Range(-rango.x, rango.x),
                                 2, Random.Range(-rango.y, rango.y)), Quaternion.identity);
        }
    }
}
