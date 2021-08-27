using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public Animator animator;

    bool jump = false;
    float hMove = 0f;
    // Update is called once per frame
    void Update()
    {
        hMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(hMove));
        if (Input.GetButtonDown("Jump")) { jump = true; animator.SetBool("isJumping", true); }
    }
    public void OnLand()
    {
        animator.SetBool("isJumping", false);
    }
    void FixedUpdate()
    {
        controller.Move(hMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
