using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text.Json;

public class Config : MonoBehaviour
{

    public string configContent;

    public ConfigInfo configInfo;
    public Config(){
        // Check if config file exists
        if(!File.Exists(this.getConfigLocation())){
            Debug.LogError("Config file not found at " + this.getConfigLocation());
        }

        configContent = getConfigContents();

        configInfo = JsonUtility.FromJson<ConfigInfo>(configContent);
    }
    
    private string configLocation = "config.txt";

    public string getConfigLocation(){
        return this.configLocation;
    }

    public string getConfigContents(){
        return File.ReadAllText(this.getConfigLocation());
    }
}


public class ConfigInfo {
    public string myGlobalVar;
}