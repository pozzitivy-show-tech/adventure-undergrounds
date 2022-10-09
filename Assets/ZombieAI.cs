using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public NavMeshAgent agent;
    private Transform player;
    private string state = "idle";
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x - transform.position.x < 0)
        {
            Debug.Log("left");
        }
        else if (player.position.x - transform.position.x > 0)
        {
            Debug.Log("right");
        }

        if (state == "idle")
        {
            agent.ResetPath();
        }
        else if (state == "attack")
        {
            agent.SetDestination(player.position);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            state = "attack";
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            state = "idle";
        }
    }
}
