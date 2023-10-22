using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class WinPoint : MonoBehaviour
{
    public string SceneName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        SceneManager.LoadScene(SceneName);

    }
}
