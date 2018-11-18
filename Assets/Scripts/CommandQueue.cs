using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueue : MonoBehaviour {

	private Queue<IAgentCommand> commands;

	void Start () {
		commands = new Queue<IAgentCommand>();
	}

	public void AddCommand(IAgentCommand c)
	{
		commands.Enqueue(c);
	}
	
	void Update ()
	{
		if(commands.Count < 1) return;
		IAgentCommand c = commands.Dequeue();
		c.Execute(null);	
	}
}
