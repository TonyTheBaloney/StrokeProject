using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    public string saveDirectory;

    public SaveSystem(string saveDirectory){
        this.saveDirectory = saveDirectory;   
    }

    public string getSaveFileName(Config config, Manager manager, int trial){
        string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd-HH:mm");
        string PidStr = config.getPID(); 
        string sensorName = "sensor";
        string experimentType = manager.GetExperimentType().ToString();
        string assesmentType = manager.GetAssesmentType().ToString();
        string trialStr = trial.ToString();

        return dateTime + "-" + PidStr + "-" + sensorName + "-" + experimentType + "-" + assesmentType + "-" + trialStr + ".txt";
    }

    public void Save(string saveName, string saveContent){
        System.IO.File.WriteAllText(saveDirectory + saveName, saveContent);
    }





}
