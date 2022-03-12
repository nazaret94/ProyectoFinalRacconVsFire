using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciaFogata : MonoBehaviour
{
    public GameObject fogata;
    public Vector2 rangof;
    public int numfogatas;
   
    private GameObject tmpFogata;

    void Start()
    {
        for (int i = 0; i <= numfogatas; i++)
        {

            tmpFogata = Instantiate(fogata, transform.position + new Vector3(Random.Range(-rangof.x, rangof.x),
                                 0.9f, Random.Range(-rangof.y, rangof.y)), Quaternion.identity);
        }
    }
}
