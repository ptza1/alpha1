﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    public float Speed;
    Rigidbody fisica;

    private void Start()
    {
        fisica = GetComponent<Rigidbody>();

    }
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        /*Vector3 playerMovement = new Vector3(hor, 0f, ver) * Speed * Time.deltaTime;
        * transform.Translate(playerMovement, Space.Self); */
        Vector3 playerMovement = new Vector3(hor, 0f, ver).normalized * Speed * Time.deltaTime;
        fisica.MovePosition(transform.position + playerMovement);
    }
}