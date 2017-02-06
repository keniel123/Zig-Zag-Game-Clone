using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {
	public static UIManager instance;
	[SerializeField]
	private GameObject zigzagpanel;
	[SerializeField]
	private GameObject gameOverPanel;
	[SerializeField]
	private Text score;
	[SerializeField]
	private Text highscore1;
	[SerializeField]
	private Text highscore2;
	[SerializeField]
	private GameObject tapText;

	void Awake(){
		if (instance == null) {
			instance = this;
		} 
	}
	// Use this for initialization
	void Start () {
		highscore1.text = "HighScore: " + PlayerPrefs.GetInt("highscore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		
		tapText.SetActive(false);
		zigzagpanel.GetComponent<Animator>().Play("panel up");
	}

	public void GameOver(){
		score.text = PlayerPrefs.GetInt("score").ToString();
		highscore2.text = PlayerPrefs.GetInt("highscore").ToString();
		
		gameOverPanel.SetActive(true);
	}

	public void Replay(){
		SceneManager.LoadScene(0);
	}
}
