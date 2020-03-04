using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public float velocidade = 5;

    Rigidbody fisica;

    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoVertical = Input.GetAxis("Vertical");

        fisica.velocity = movimentoVertical * velocidade * transform.forward;

        float movimentoHorizontal = Input.GetAxis("Horizontal");

        transform.Rotate(0, movimentoHorizontal * velocidade, 0);
    }
}
