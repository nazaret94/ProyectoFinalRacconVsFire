using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Solis Torres Mariana Nazaret

public class Arboles : MonoBehaviour
{
    //Event
    public delegate void Panel();
    public static event Panel PanelWin;
    public static event Panel PanelGameOver;

    //Subscripcion a evento
    private void OnEnable()
    {
        ArbolCollider.ApagaA += ApagaArbol;
    }

    private void OnDisable()
    {
        ArbolCollider.ApagaA -= ApagaArbol;
    }

    public AnimatorStateInfo arbolStateInfo;
    public Animator []arboles;

    public int numArbolesSinFuego = 10;
    public int numArbolesFuego = 0;

    void Start()
    {
        StartCoroutine("PrendeArbol");
    }

    IEnumerator PrendeArbol()
    {
       
        arboles[0].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
        
        arboles[1].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
       
        arboles[2].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; 
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
        
        arboles[3].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; 
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
        
        arboles[4].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1; 
        yield return new WaitForSeconds(7f);
       
        arboles[5].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
       
        arboles[6].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);

        arboles[7].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);

        arboles[8].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);

        arboles[9].SetBool("ArbolF", true);
        numArbolesSinFuego -= 1;
        numArbolesFuego += 1;
        yield return new WaitForSeconds(7f);
        yield return new WaitForSeconds(1f);
        PanelGameOver();
    }

 public void ApagaArbol()
    {
        numArbolesSinFuego += 1;
        numArbolesFuego -= 1;

        if (numArbolesSinFuego == 0)
        {
            PanelWin();
        }
    }

}
