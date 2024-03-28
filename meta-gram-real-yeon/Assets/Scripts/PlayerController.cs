using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    Vector3 dir;
    Animator animator;
    CharacterController characterController;
    public float speed = 20.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        dir = new Vector3(h, 0, v) * speed;

        if (dir != Vector3.zero)
        {
           Vector3 lookDir = new Vector3(h, 0, v);
            transform.rotation = Quaternion.LookRotation(lookDir);
            animator.SetBool("isWalk", true);
        }
        else
            animator.SetBool("isWalk", false);

        if (Input.GetKeyDown(KeyCode.Space))
            dir.y = 5f;

        dir.y += Physics.gravity.y * Time.deltaTime;
        characterController.Move(dir * Time.deltaTime);

    }
}