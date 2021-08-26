using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mirror;
using Unity.VisualScripting;
using UnityEngine;


public class FPSPlayerController : NetworkBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private Rigidbody rb = null;

    private Vector2 previousInput;

    

    public override void OnStartAuthority()
    {
        base.OnStartAuthority();
        enabled = true;
    }


    [ClientCallback]
    private void Update() => Move();


    [Client]
    private void SetMovement(Vector2 movement) => previousInput = movement;

    [Client]
    private void ResetMovement() => previousInput = Vector2.zero;

    [Client]
    private void Move()
    {
        Vector3 dir = new Vector3(0, 0, 0);
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");
        rb.transform.Translate(dir * movementSpeed * Time.deltaTime);
    }
}