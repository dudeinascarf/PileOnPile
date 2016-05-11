using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {


	public Text bestScoreText;


	private void Start(){
		bestScoreText.text = PlayerPrefs.GetInt ("score").ToString();
	}
		
	public void PlayGame(){
		SceneManager.LoadScene ("Gameplay");
	}
}
