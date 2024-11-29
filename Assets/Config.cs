using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Config : MonoBehaviour
{

    string configContent;

    ConfigInfo configInfo;
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

    public string getPID(){
        return configInfo.PID;
    }
}


public class ConfigInfo {
    public bool recording;
    public string recordingDirectory;
    public string PID;

}