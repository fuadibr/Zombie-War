using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    public Transform[] targets;
    int targetIndex = 0;
    float reachDistance = 0.55f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float distance2target = Vector3.Distance(transform.position,targets[targetIndex].position);
        agent.destination = targets[targetIndex].position;
        Debug.Log(distance2target);
        if(distance2target > reachDistance)
        {
            anim.SetBool("walking",true);
        }
        else
        {
            anim.SetBool("walking",false);
            targetIndex++;
            if(targetIndex > targets.Length - 1)
            {
                targetIndex = 0;
            }
        }
    }
}
