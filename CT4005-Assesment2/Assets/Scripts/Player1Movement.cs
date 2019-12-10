using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
   public float speed = 12f;
    public CharacterController controller;

    [SerializeField]
    private string controllerPrefix = "";

  
    void Update()
    {
        float x = Input.GetAxis(controllerPrefix + "Horizontal");
        float z = Input.GetAxis(controllerPrefix + "Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
