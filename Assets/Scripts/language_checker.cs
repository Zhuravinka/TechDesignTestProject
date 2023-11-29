using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization.Settings;
public class language_checker : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Respawn"); // Замените "YourTag" на тэг вашего объекта
        if (objs.Length > 1)
        {
            // Если объект с таким тегом уже существует, уничтожьте текущий объект
            Destroy(gameObject);
        }
        else
        {
            // Если объекта с таким тегом нет, установите тег и предотвратите его уничтожение при загрузке новой сцены
            DontDestroyOnLoad(gameObject);
            gameObject.tag = "Respawn"; // Замените "YourTag" на тэг вашего объекта
        }
    }
}