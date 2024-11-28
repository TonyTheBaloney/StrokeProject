using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Manager : MonoBehaviour {
	
	public string myGlobalVar = "whatever";

	public Config config = new Config();

	private static Manager _instance;
	public static Manager Instance { get { return _instance; } }
	
	private void Awake()
    {
        if (_instance != null && _instance != this)
        {
        	Destroy(this.gameObject);
        } else {
        	_instance = this;
        }
    }

}
