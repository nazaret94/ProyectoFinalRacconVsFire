using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigo : MonoBehaviour
{
    public GameObject MegaFlama;
    public Animator MegaFlAnimator;
    public float VidaMegaflama = 5;

   public void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Agua")
        {
            
            if(VidaMegaflama == 0)
            {
                MegaFlAnimator.SetBool("Attack",false);
                MegaFlAnimator.SetTrigger("Die");
                Destroy(MegaFlama, 2f);
            }
            if(VidaMegaflama < 6 && VidaMegaflama > 0)
            {
              VidaMegaflama -= 1;
            }
        }
    }

}
