using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrap : MonoBehaviour
{
    public GameObject MoveObject;
    public Vector3 MoveTo;
    private bool Triggered = false;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (!Triggered)
        {
            print("AA");
            MoveObject.transform.position = MoveTo;
            Triggered = true;
        }
    }
}
