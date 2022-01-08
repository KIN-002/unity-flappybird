using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	public float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;
	private Animator anim;


	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();		
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false)
		{
			if (Input.GetMouseButtonDown (0))
			{
				rb2d.velocity = Vector2.zero; //設定速度為0
				rb2d.AddForce(new Vector2(0,upForce));  //加向上進力
				anim.SetTrigger("Flap");
			}
		}
	}
	void OnCollisionEnter2D()
	{
		rb2d.velocity = Vector2.zero;
		isDead = true;
		anim.SetTrigger ("Die");
		gameControl.instance.BirdDied ();
	}
}
