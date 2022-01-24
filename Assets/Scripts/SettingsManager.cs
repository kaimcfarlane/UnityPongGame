using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{

     public string settingsMenu;
     private Color defaultColor = new Color(77f/255f, 211f/255f, 243f/255f, 0f/255f);
     public static Color SMcolor = new Color(77f/255f, 211f/255f, 243f/255f, 0f/255f);
     public string mainMenu;
     public Camera cm;



    public void openSettingsMenu() {
        SceneManager.LoadScene(settingsMenu);
    }

    //should change pong background and pon pause
    public void ppColorRed() { 
        // cm.backgroundColor = SMcolor;
        SMcolor = Color.red;
    }

    public void ppColorStar() { 
        // cm.backgroundColor = SMcolor;
        SMcolor = Color.black;
    }

    public void ppColorGold() { 
        // cm.backgroundColor = SMcolor;
        SMcolor = new Color(250f/255f, 193f/255f, 0f/255f, 255f/255f);
    }

    public void ppColorDefault() {
        SMcolor = defaultColor;
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
