using UnityEngine;
using System.Collections;

public class CharControl : MonoBehaviour 
{
	//Animator Controller
	private Animator ThisAnimator = null;

	//Float names
	private int HorzFloat = Animator.StringToHash("Horz");
	private int VertFloat = Animator.StringToHash("Vert");
	
	void Awake()
	{
		ThisAnimator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () 
	{
		float Vert = Input.GetAxis("Vertical");
		float Horz = Input.GetAxis("Horizontal");

		ThisAnimator.SetFloat(HorzFloat, Horz, 0.2f, Time.deltaTime);
		ThisAnimator.SetFloat(VertFloat, Vert, 0.2f, Time.deltaTime);
	}
}
