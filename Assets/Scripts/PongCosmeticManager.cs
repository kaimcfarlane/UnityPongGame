using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongCosmeticManager : MonoBehaviour
{


    private Color color = SettingsManager.SMcolor;
    public Camera cm;
    // Start is called before the first frame update
    
    void Start()
    {
        cm.backgroundColor = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
