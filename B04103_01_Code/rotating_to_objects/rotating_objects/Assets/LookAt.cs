//--------------------------------------------
using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
//--------------------------------------------
public class LookAt : MonoBehaviour
{
	//Cached transform
	private Transform ThisTransform = null;

	//Target to look at
	public Transform Target = null;

	//Rotate speed
	public float RotateSpeed = 100f;

	//--------------------------------------------
	// Use this for initialization
	void Awake () {
		//Get transform for this object
		ThisTransform = GetComponent<Transform>();
	}
	//--------------------------------------------
	void Start()
	{
		//Start tracking target
		StartCoroutine(TrackRotation(Target));
	}
	//--------------------------------------------
	//Coroutine for turning to face target
	IEnumerator TrackRotation(Transform Target)
	{
		//Loop forever and track target
		while(true)
		{
			if(ThisTransform != null && Target != null)
			{
				//Get direction to target
				Vector3 relativePos = Target.position - ThisTransform.position;

				//Calculate rotation to target
				Quaternion NewRotation = Quaternion.LookRotation(relativePos);

				//Rotate to target by speed
				ThisTransform.rotation = Quaternion.RotateTowards(ThisTransform.rotation, NewRotation, RotateSpeed * Time.deltaTime);
			}

			//wait for next frame
			yield return null;
		}
	}
	//--------------------------------------------
	//Function to draw look direction in viewport
	void OnDrawGizmos()
	{
		Gizmos.DrawLine(ThisTransform.position, ThisTransform.forward.normalized * 5f);
	}
	//--------------------------------------------
}
//--------------------------------------------