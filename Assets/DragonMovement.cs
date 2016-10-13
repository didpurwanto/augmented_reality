using UnityEngine;
using System.Collections;

public class DragonMovement : MonoBehaviour {

	// Use this for initialization

	Animator anim;
	int frame = 0;
	int second = -1;

	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetBool ("goAttack", false);
		anim.SetBool ("goFire", false);
	}
	
	// Update is called once per frame
	void Update () {
		frame++;
		if (frame % 60 == 0)
						second++;
		if (second % 5 == 10) 
						anim.SetBool ("goAttack", false);
	}
}
