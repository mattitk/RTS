using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour {
	List<IAgentBehaviour> behaviours;
	
	void Start () {
		behaviours = new List<IAgentBehaviour>();	
	}

	public void AddBehaviour(IAgentBehaviour behaviour)
	{
		// TODO validate behaviour ?
		behaviours.Add(behaviour);
	}

	public void ExecuteBehaviours()
	{

	}
	
	void Update () {
		ExecuteBehaviours();
	}
}
