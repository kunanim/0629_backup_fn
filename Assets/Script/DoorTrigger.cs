using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Animator doorAnimator;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetTrigger("Open");
        }
    }
}
