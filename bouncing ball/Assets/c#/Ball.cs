using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {


	public GUIText scoreText;
	public int score;

		


	

		void Start (){
			
			score = 0;
			UpdateScore ();
		
			}
		

		public void AddScore (int newScoreValue)  

	
{
	        score += newScoreValue;
			UpdateScore ();
		}

		void UpdateScore ()
		{
			scoreText.text = "Score: " + score;
		Debug.Log ("you got a a friend in me");
		}
}

