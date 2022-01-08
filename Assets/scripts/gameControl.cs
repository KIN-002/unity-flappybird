using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControl : MonoBehaviour {

	public static gameControl instance;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float scrollSpeed = -1.5f;


	void Awake()   //Awake是在start之前執行, 
	{
		if (instance == null) //如果沒有物件執行
		{
			instance = this;  //執行這個
		}
		else if (instance != this)  //如果己有一個物件執行
		{
			Destroy (gameObject);  //就毁滅這個物件
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		
	}

	public void BirdDied()
	{
		gameOverText.SetActive (true);  
		gameOver = true;
	}

	public void BirdScored()
	{
		if (gameOver) 
		{
			return;
		}


	}
}
