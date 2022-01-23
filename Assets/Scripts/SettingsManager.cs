using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

     public string settingsMenu;
     private Color defaultColor = new Color(20f/255f, 255f/255f, 186f/255f, 0f/255f);
     public static Color SMcolor = new Color(20f/255f, 255f/255f, 186f/255f, 0f/255f);
     public string mainMenu;
     public Camera cm;


    public void openSettingsMenu() {
        SceneManager.LoadScene(settingsMenu);
    }

    public void changeSMcolor() { 
        cm.backgroundColor = SMcolor;
        SMcolor = Color.blue;
        // SettingsManager.SMcolor = Color.blue;
    }

    public void goMainMenu() {
        SceneManager.LoadScene(mainMenu);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
