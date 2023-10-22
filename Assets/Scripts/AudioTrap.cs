using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrap : MonoBehaviour
{
    public AudioClip TrapSound;
    public bool IsAudio = true;
    private bool Triggered = false;
    void Start()
    {
    }
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        if (IsAudio && !Triggered)
        {
            var source = GetComponent<AudioSource>();
            source.PlayOneShot(TrapSound);
            Triggered = true;
        }
    }
}
