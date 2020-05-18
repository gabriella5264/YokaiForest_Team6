using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swim : MonoBehaviour
{

    //This script enables underwater effects. Attach to main camera.

    //Define variable
    public GameObject person;
    
    
    private bool underwaterLevel = false;



    // Start is called before the first frame update
    void Start()
    {
        //The scene's default fog settings
    bool defaultFog = RenderSettings.fog;
    Color defaultFogColor = RenderSettings.fogColor;
    float defaultFogDensity = RenderSettings.fogDensity;
}


    public void OnTriggerEnter(Collider other)
        {
            if (person.tag.Equals("Player"))
            {
                underwaterLevel = true;
            }
            
        }
        public void OnTriggerExit(Collider other)
        {
            underwaterLevel = false;
        }
    


    // Update is called once per frame
    void Update()
    {
        if (underwaterLevel == true)
        {

            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
            RenderSettings.fogDensity = 0.04f;
            
        }
        else if (underwaterLevel == false)
        {
            RenderSettings.fog = false;
        }
    }
}