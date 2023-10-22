using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using static Unity.Collections.AllocatorManager;

public class HoverButton : MonoBehaviour
{

    public GameObject Flash;
    public GameObject Eyes;
    public GameObject Arrow;
    public AudioClip Whoosh;
    private bool flashBool = false;
    public float FlashPower = 20;
    public float FlashTimer = 1.3f;



    void Start()
    {
        
    }

    void Update()
    {
        if (flashBool)
        {
            var source = GetComponent<AudioSource>();
            source.PlayOneShot(Whoosh);

            Flash.gameObject.GetComponent<Light2D>().pointLightOuterRadius += FlashPower * Time.deltaTime;
            Flash.gameObject.GetComponent<Light2D>().intensity += FlashPower * Time.deltaTime;
            FlashTimer -= Time.deltaTime;
            print(FlashTimer);
            if (FlashTimer < 0)
            {
                SceneManager.LoadScene("Room1");
            }
        }
    }

    private void OnMouseEnter()
    {
        Eyes.gameObject.SetActive(false);
        Arrow.gameObject.SetActive(false);
        Flash.gameObject.SetActive(true);
        flashBool = true;


    }

}
