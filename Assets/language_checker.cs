using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization.Settings;
public class language_checker : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Respawn"); // �������� "YourTag" �� ��� ������ �������
        if (objs.Length > 1)
        {
            // ���� ������ � ����� ����� ��� ����������, ���������� ������� ������
            Destroy(gameObject);
        }
        else
        {
            // ���� ������� � ����� ����� ���, ���������� ��� � ������������� ��� ����������� ��� �������� ����� �����
            DontDestroyOnLoad(gameObject);
            gameObject.tag = "Respawn"; // �������� "YourTag" �� ��� ������ �������
        }
    }
}