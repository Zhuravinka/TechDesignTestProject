using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable : MonoBehaviour
{
    [SerializeField] float sound_delay;
    Animator _animator;
    AudioSource _sound;
    float _timer;
    void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
        _sound = GetComponent<AudioSource>();

    }

    
    void Update()
    {
        _timer += Time.deltaTime;
    }
    void OnMouseDown()
    {
        if (_timer > 1f)
        {
            _animator.SetTrigger("click");

            if (_sound)
            {
                StartCoroutine(playSoundWithDelay(_sound.clip, sound_delay));
               
            }

            _timer = 0;
        }
            
        
        
    }
    IEnumerator playSoundWithDelay(AudioClip clip, float sound_delay)
    {
        yield return new WaitForSeconds(sound_delay);
        _sound.PlayOneShot(_sound.clip);
    }
}
