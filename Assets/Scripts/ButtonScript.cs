using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	private CommandQueue commandQueue;

	void Start () {
		commandQueue = GameObject.Find("CommandQueue").GetComponent<CommandQueue>();
	}

	public void AddNewCommand()
	{
		//Vector3 pos = Vector3.zero;
		//Quaternion rot = Quaternion.identity;
		Vector3 newVector3 = new Vector3();
		newVector3.x = 24;
		if(commandQueue != null) 
			commandQueue = GameObject.Find("CommandQueue").GetComponent<CommandQueue>();
		Spawn c = new Spawn("testiprefab", newVector3, Quaternion.identity);
		commandQueue.AddCommand(c);
	}
	
}
