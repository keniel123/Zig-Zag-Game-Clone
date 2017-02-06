using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	public static ScoreManager instance;
	[SerializeField] private int score;
	[SerializeField] private int highscore;
	// Use this for initialization

	void Awake(){
		
		if (instance == null) {
			instance = this;
		} 
	}
	
	void Start () {
		score = 0;
		PlayerPrefs.SetInt("score",score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void incrementScore(){
		score += 1;
	}

	public void startScore(){
		InvokeRepeating("incrementScore",.1f,.5f);
	}

	public void stopScore(){
		CancelInvoke("incrementScore");
		PlayerPrefs.SetInt("score",score);

		if (PlayerPrefs.HasKey("highscore"))
		{
			if (score > PlayerPrefs.GetInt("highscore"))
			{
				PlayerPrefs.SetInt("highscore",score);
			}
		}else{
			PlayerPrefs.SetInt("highscore",score);
		}

	}


}
