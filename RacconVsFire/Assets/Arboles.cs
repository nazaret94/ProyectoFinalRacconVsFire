using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arboles : MonoBehaviour
{
    
    public AnimatorStateInfo arbolStateInfo;
    public Animator []arboles;

    void Start()
    {
        StartCoroutine("PrendeArbol");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PrendeArbol()
    {
        arboles[0].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[1].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[2].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[3].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[4].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[5].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[6].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[7].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[8].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);
        arboles[9].SetBool("ArbolF", true);
        yield return new WaitForSeconds(4f);

    }
}
