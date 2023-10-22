using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreamerTrap : MonoBehaviour
{
    public AudioClip TrapSound;
    public GameObject Picture;
    private bool Triggered = false;
    public float TrapTimer = 4f;

    private void Update()
    {
        if (Triggered)
        {
            TrapTimer -= Time.deltaTime;
            if (TrapTimer < 0)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
    private void OnMouseEnter()
    {
        var source = GetComponent<AudioSource>();
        source.PlayOneShot(TrapSound);
        Picture.gameObject.SetActive(true);
        Triggered = true;
    }
}
