using UnityEngine;
using UnityEngine.Playables;

public class PlayOnEnter : MonoBehaviour
{
    [Tooltip("첫 씬용 Timeline")]
    public PlayableDirector director;     

    

    private bool played = false;

    void Awake()
    {
        if (director  != null) director.Stop();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!played && other.CompareTag("Player"))
        {
            played = true;
            // 1) 첫 번째 타임라인 시작
            director.Play();
            // 2) 첫 타임라인이 끝나면 director2 재생
           
        }
    }
}
