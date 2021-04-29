using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour 
{
	//Amount to travel (in metres) per second
	public float Speed = 1f;

	//Direction to travel
	public Vector3 Direction = Vector3.zero;
	
	// Update is called once per frame
	void Update () 
	{
		//Transform component on this object
		Transform ThisTransform = GetComponent<Transform>();

		//Update position in specified direction by speed
		ThisTransform.position += Direction.normalized * Speed * Time.deltaTime;
	}
}
