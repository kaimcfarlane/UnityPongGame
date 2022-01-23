using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GoToSettings : MonoBehaviour
{
    public string settingsMenu;


    public void openSettingsMenu() {
        SceneManager.LoadScene(settingsMenu);
    }
}
