using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inimigoSeguindo : MonoBehaviour
{
    NavMeshAgent agente;
    public Transform player;
    float offset = 1f;

    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(player.position, this.transform.position) >= offset)
        {
            agente.SetDestination(player.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Voce morreu");
        }
    }
}
