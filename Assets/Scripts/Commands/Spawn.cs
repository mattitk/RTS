using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//var instance : GameObject = Instantiate(Resources.Load("enemy"));


public class Spawn : IAgentCommand {
	//private Transform target;
	private string prefabName;
	private Vector3 targetPos;
	private Quaternion targetRot;
	public Spawn(string prefabName, Vector3 targetPos, Quaternion targetRot)
	{
		if(targetPos == null) targetPos = Vector3.zero;
		if(targetRot == null) targetRot = Quaternion.identity;
		this.targetPos = targetPos;
		this.targetRot = targetRot;
	//	target.position = targetPos;
	//	target.rotation = targetRot;
		this.prefabName = prefabName;
	}
	
	public void Execute(GameObject agent)
	{
		if(prefabName == null) return;
		GameObject go = (GameObject) GameObject.Instantiate(Resources.Load(prefabName));
		go.transform.position = targetPos;
		go.transform.rotation = targetRot;
	}
}
