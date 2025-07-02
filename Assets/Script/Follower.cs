using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > 2f)
        {
            agent.SetDestination(target.position);
            anim.SetBool("isDancing", false); // 걷기
        }
        else
        {
            agent.ResetPath();
            anim.SetBool("isDancing", true); // 춤추기
        }
    }
}
