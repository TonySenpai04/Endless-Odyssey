using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Shooting();
        }else if (Input.GetKey(KeyCode.S))
        {
            Walk();
        }
    }
    public void Shooting()
    {
        animator.SetBool("isShoot", true);
    }
    public void Walk()
    {
        animator.SetBool("isShoot", false);
    }
}
