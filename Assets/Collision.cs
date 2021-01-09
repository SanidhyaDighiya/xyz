using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	public int mynum;
	public PlayerMovement m;
        private GenerateCube generate;
	
	void Start()
	{
		generate = GetComponent<GenerateCube>();
	}
	void OnCollisionEnter(){
		FindObjectOfType<Gamemanager>().EndGame();
		FindObjectOfType<Gamemanager>().GameOver();
		m.enabled = false;
	}
}
