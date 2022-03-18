using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemigo : MonoBehaviour
{
    public Transform []puntosControl;
    private NavMeshAgent enemigo;
    private Animator enemigoAnimator;
    private Transform Roco;
    private EnemyState currentState;

    private float cDistancia;
    public float perseguirDistancia;
    public float peleaDistancia;

    void Start()
    {
        enemigo = GetComponent<NavMeshAgent>();
        enemigoAnimator = GetComponent<Animator>();
        Roco = GameObject.FindGameObjectWithTag("Roco").transform;
        currentState = EnemyState.CAMINANDO;
        Caminando();
    }

    private void Update()
    {
        cDistancia = (Roco.position - transform.position).magnitude;

        switch (currentState)
        {
            case EnemyState.CAMINANDO:
                if (cDistancia <= perseguirDistancia)
                {
                    currentState = EnemyState.PERSIGUIENDO;
                    Persiguiendo();
                }
                break;

            case EnemyState.PERSIGUIENDO:
                enemigo.SetDestination(Roco.position);
                if (enemigo.remainingDistance <= peleaDistancia)
                {
                    currentState = EnemyState.PELEANDO;
                   Pelea();
                }
                else if (enemigo.remainingDistance > peleaDistancia)
                {
                 enemigoAnimator.SetBool("Attack", false);
                enemigoAnimator.SetBool("Walk Forward",true);
                    currentState = EnemyState.CAMINANDO;
                    Caminando();
                }
                break;
            case EnemyState.PELEANDO:
                if (cDistancia> peleaDistancia)
                {
                    currentState = EnemyState.PERSIGUIENDO;
                    
                    Persiguiendo();
                }
              
                break;
        }

    }

    public void Destino()
    {
        enemigo.SetDestination(puntosControl[Random.Range(0,
                                puntosControl.Length)].position);
    }

    public void Caminando()
    {
       
     InvokeRepeating("Destino", 0f, 4f);
    }

    public void Persiguiendo()
    {
        enemigoAnimator.SetBool("Attack", false);
        CancelInvoke();
        enemigo.SetDestination(Roco.position);
    }

    private void Pelea()
    {
        enemigoAnimator.SetBool("Walk Forward", false);
        enemigoAnimator.SetBool("Attack",true);
        enemigo.transform.LookAt(Roco);
    }

    public enum EnemyState { CAMINANDO,PERSIGUIENDO,PELEANDO}
}
