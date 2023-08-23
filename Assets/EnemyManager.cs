using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    private const string _TAG_NAME = "Player";
    private NavMeshAgent navMeshAgent;
    public Animator animator;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        player = GameObject.FindGameObjectWithTag(_TAG_NAME);
    }

    void Start()
    {
           
    }

    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
        
        animator.SetBool("run", navMeshAgent.velocity.magnitude > 0.1);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == _TAG_NAME)
        {
            Debug.Log("Player HIt!!!");
        }
    }
}
