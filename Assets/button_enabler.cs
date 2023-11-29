using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class button_enabler : MonoBehaviour
{
    private AudioSource aud;
    public GameObject button;
    
    void Start()
    {
        
        aud = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {

        button.SetActive(true);
        aud.Play();

    }

}
