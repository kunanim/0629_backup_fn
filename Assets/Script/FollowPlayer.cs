using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), typeof(Animator))]
public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    private Animator anim;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // 플레이어 쪽으로 이동
        agent.destination = player.position;

        // 속도에 따라 Blend Tree 파라미터 설정
        float speed = agent.velocity.magnitude;
        anim.SetFloat("Speed", speed);
    }
}
