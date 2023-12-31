using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class language_switcher : MonoBehaviour
{
    private bool active = false;
    public void ChangeLocale(int localeID)
    { 
        if (active == true)
            return;
        if (localeID < 4)
            StartCoroutine(SetLocale(localeID));

    }
    IEnumerator SetLocale(int _localeID)
    {
        
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        active = false;
    } 
}

