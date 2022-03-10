using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arboles : MonoBehaviour
{ 
    public AnimatorStateInfo arbolStateInfo;
    public Animator []arboles;

    public GameObject panelGameOver;
    public GameObject panelWin;

    public int numArbolesSinFuego = 10;
    public int numArbolesFuego = 0;

    void Start()
    {
        StartCoroutine("PrendeArbol");
    }

    private void Update()
    {
       
        if (numArbolesSinFuego == 0)
        {
           panelWin.SetActive(true);
        }

        if (numArbolesFuego == 10)
        {
            panelGameOver.SetActive(true);
        }
    }

    IEnumerator PrendeArbol()
    {
       
        arboles[0].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//10-1=9
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
        
        arboles[1].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//9-1=8
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
       
        arboles[2].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; //8 - 1 = 7
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
        
        arboles[3].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; //7-1=6
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
        
        arboles[4].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; //6-1=5
        yield return new WaitForSeconds(4f);
       
        arboles[5].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//5-1=4
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
       
        arboles[6].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//4-1=3
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);

        arboles[7].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//3-1=2
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);

        arboles[8].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//2-1=1
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);

        arboles[9].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;//1-1=0
        numArbolesFuego += 1;
        yield return new WaitForSeconds(4f);
        Debug.Log("Game Over"+numArbolesSinFuego);
        
    }

 public void ApagaArbol()
    {
        numArbolesSinFuego += 1;
        numArbolesFuego -= 1;
    }
}
