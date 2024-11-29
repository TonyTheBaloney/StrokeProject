using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AssesmentType {
	BoxAndBlocks,
	FuglMeyer
}

public enum ExperimentType {
	MarioKart,
	MarioParty,
	Tennis
}

public class Manager : MonoBehaviour {
	
	AssesmentType assesmentType = AssesmentType.BoxAndBlocks;
	ExperimentType experimentType = ExperimentType.MarioKart;

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

	public AssesmentType GetAssesmentType() {
		return assesmentType;
	}

	public ExperimentType GetExperimentType() {
		return experimentType;
	}

	public void SetAssesmentType(AssesmentType assesmentType) {
		this.assesmentType = assesmentType;
	}

	public void SetExperimentType(ExperimentType experimentType) {
		this.experimentType = experimentType;
	}

	public Config GetConfig() {
		return config;
	}
	
}
