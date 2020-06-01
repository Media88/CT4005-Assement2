using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    public float speed = 12f;
    public CharacterController controller;
    
    public Animator anim;

    [SerializeField]
    private string controllerPrefix = "";

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void Update()
    {

        float x = Input.GetAxis(controllerPrefix + "Horizontal");
        float z = Input.GetAxis(controllerPrefix + "Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(x < 0 )
        {
            anim.SetBool("isBack", true);
        }
        else
        {
            anim.SetBool("isBack", false);
        }

        if (x > 0)
        {
            anim.SetBool("isForward", true);
        }
        else
        {
            anim.SetBool("isForward", false);
        }

        if (z > 0)
        {
            anim.SetBool("isDown", true);
        }
        else
        {
            anim.SetBool("isDown", false);
        }

        if (z < 0)
        {
            anim.SetBool("isUp", true);
        }
        else
        {
            anim.SetBool("isUp", false);
        }
    }
}
