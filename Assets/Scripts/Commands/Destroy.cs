using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//var instance : GameObject = Instantiate(Resources.Load("enemy"));


public class Destroy : IAgentCommand {

	public Destroy()
	{
	}
	
	public void Execute(GameObject agent)
	{
		GameObject.Destroy(agent);
	}
}
