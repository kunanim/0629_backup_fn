using UnityEngine;
using UnityEngine.Playables;


[RequireComponent(typeof(PlayableDirector))]
public class TimelineDistanceController : MonoBehaviour
{
    [Tooltip("The player Transform")]
    public Transform player;
    [Tooltip("The NPC Transform to measure distance from")]
    public Transform npc;
    [Tooltip("Pause the Timeline when player is farther than this")]
    public float maxDistance = 5f;


    PlayableDirector director;


    void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.Pause(); // start paused
    }


    void Update()
    {
        if (player == null || npc == null) return;


        float dist = Vector3.Distance(player.position, npc.position);
        bool inRange = dist <= maxDistance;


        if (inRange && director.state != PlayState.Playing)
            director.Play();
        else if (!inRange && director.state == PlayState.Playing)
            director.Pause();
    }
}



