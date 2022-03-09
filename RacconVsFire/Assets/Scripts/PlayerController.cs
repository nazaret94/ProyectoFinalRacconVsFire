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
   float jx;
   float jz;

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
     
        jx = joystickMover.Horizontal + Input.GetAxis("Horizontal");
        jz = joystickMover.Vertical + Input.GetAxis("Vertical");
       Debug.Log("x" + jx+"z"+ jz);
        if ((jx > .02 && jz > .02) || (jx > .02 && jz < -.02)|| (jx < -.02 && jz > .02)|| (jx < -.02 && jz < -.02))
        {
            rocoAnimator.SetBool("Caminar", true);
            Mover(jx, jz);
        }

        if ((jx < .01 && jz < .01) || (jx < .01 && jz > -.01) || (jx > -.01 && jz < .01) || (jx > -.01 && jz > -.01))
        {
            rocoAnimator.SetBool("Caminar", false);
        }

        Rotar();
    }

    void Mover(float x, float z)
    {
        controller.Move((roco.transform.forward * z * Time.deltaTime) + (roco.transform.right * speed * x * Time.deltaTime));
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