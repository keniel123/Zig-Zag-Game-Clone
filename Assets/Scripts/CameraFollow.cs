using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	private GameObject ball;
	private Vector3 offset;
	[SerializeField]
	private float LerpRate;
	public bool gameOver;
	// Use this for initialization
	void Start () {
		offset = ball.transform.position - transform.position;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver)
		{
			Follow();
			
		}
	}

	void Follow(){
		Vector3 pos = transform.position;
		Vector3 targetPos = ball.transform.position - offset;
		pos = Vector3.Lerp(pos,targetPos,LerpRate * Time.deltaTime);
		transform.position = pos;
	}
}
