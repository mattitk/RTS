using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//var instance : GameObject = Instantiate(Resources.Load("enemy"));


public class Spawn : IAgentCommand {
	//private Transform target;
	private string prefabName;

	public Spawn(string prefabName, Vector3 targetPos, Quaternion targetRot)
	{
	//	target.position = targetPos;
	//	target.rotation = targetRot;
		this.prefabName = prefabName;
	}
	
	public void Execute(GameObject agent)
	{
		if(prefabName == null) return;
		Debug.Log("Instantiating");
		GameObject.Instantiate(Resources.Load(prefabName));
	}
}
