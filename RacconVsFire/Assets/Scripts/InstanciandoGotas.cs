using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciandoGotas : MonoBehaviour
{

    public GameObject gotas;
    public Vector2 gotasf;
    public int numgotas;

    private GameObject tmpGota;

    void Start()
    {
        for (int i = 0; i <= numgotas; i++)
        {

            tmpGota = Instantiate(gotas, transform.position + new Vector3(Random.Range(-gotasf.x, gotasf.x),
                                 2f, Random.Range(-gotasf.y, gotasf.y)), Quaternion.identity);
        }
    }

}
