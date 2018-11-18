using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//var instance : GameObject = Instantiate(Resources.Load("enemy"));


public class Spawn : ICommand {
	private Transform target;
	private string prefabName;

	Spawn(string prefabName, Transform target)
	{
		this.prefabName = prefabName;
	}
	
	public void Execute()
	{
		if(prefabName != null) return;
		GameObject.Instantiate(Resources.Load(prefabName));
	}
}
