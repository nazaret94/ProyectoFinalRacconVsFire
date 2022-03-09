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
   float x;
   float z;

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
        Debug.Log("x" + Input.GetAxis("Horizontal"));
        x = joystickMover.Horizontal + Input.GetAxis("Horizontal");
        z = joystickMover.Vertical + Input.GetAxis("Vertical");
        rocoAnimator.SetBool("Caminar", true);
        controller.Move((roco.transform.forward * z * Time.deltaTime) + (roco.transform.right * speed * x * Time.deltaTime));
    }
    void Rotar()
    {
        rotH = joystickGirar.Horizontal* speedRot;
        rotV = joystickGirar.Vertical*speedRot;
        camarav.Rotate(rotV,0,0);
        roco.Rotate(0, rotH, 0);
    }
  

}