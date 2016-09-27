using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public int scoreValue;
	public Ball ball;
	public AudioSource Zelda;
	public AudioClip clip;

	public void Awake (){

		Zelda = GetComponent <AudioSource> ();
	}

	public void OnTriggerEnter(Collider other){
		

	}











	 //Update is called once per frame
	void Update ()
	{
		Zelda.Play();

		ball.AddScore (scoreValue);

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			transform.position += new Vector3 (0, 0, 1);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			transform.position += new Vector3 (0, 0, -1);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (-1, 0, 0);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			transform.position += new Vector3 (1, 0, 0);
		}

	}
}
		
	

