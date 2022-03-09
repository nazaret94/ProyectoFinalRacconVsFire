using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//solis Torres Mariana Nazaret

public class PlayerController : MonoBehaviour
{
    public Joystick joystickMover;
    public Joystick joystickGirar;

    public CharacterController controller;
    public Transform roco;

    public float speed;
   float jx = 0;
    float jz = 0;
 

    public float speedRot;
    float rotH;
    float rotV;

    public Animator rocoAnimator;
    public AnimatorStateInfo rocoStateInfo;
    Vector3 mover;

    Transform camarav;

    private void Start()
    {
        camarav = Camera.main.transform;
    } 

    private void Update()
    {
        rocoStateInfo = rocoAnimator.GetCurrentAnimatorStateInfo(0);
        Mover();
        Rotar();
    }

    void Mover()
    {
        jx = joystickMover.Horizontal + Input.GetAxis("Horizontal");
        jz = joystickMover.Vertical + Input.GetAxis("Vertical");

        if ((jx >= .03 && jz >= .03) || (jx >= .03 && jz <= -.03)|| (jx <= -.03 && jz >= .03)|| (jx <= -.03 && jz <= -.03))
        {
       //    rocoAnimator.SetTrigger("Caminar");
          
            controller.Move((roco.transform.forward * jz * Time.deltaTime) + (roco.transform.right * speed * jx * Time.deltaTime));
        }
        else
        {

        }
        
    }

    void Rotar()
    {
        rotH = joystickGirar.Horizontal* speedRot;
        rotV = joystickGirar.Vertical*speedRot;
        camarav.Rotate(rotV,0,0);
        roco.Rotate(0, rotH, 0);
    }

    public void Correr()
    {
        rocoAnimator.SetTrigger("Correr");
    }

    public void Dispara()
    {
     rocoAnimator.SetTrigger("Dispara");
    }

    public void Globo()
    {
     rocoAnimator.SetTrigger("Globo");
    }

}