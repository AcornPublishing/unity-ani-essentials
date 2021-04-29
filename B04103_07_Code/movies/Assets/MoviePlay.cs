using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour 
{
	//Reference to movie to play
	public MovieTexture Movie = null;
	
	// Use this for initialization
	void Start () 
	{
		//Get Mesh Renderer Component
		MeshRenderer MeshR = GetComponent<MeshRenderer>();
		
		//Assign movie texture
		MeshR.material.mainTexture = Movie;
		
		GetComponent<AudioSource>().clip = Movie.audioClip; 
		GetComponent<AudioSource>().spatialBlend=0;
	
		Movie.Play();
		GetComponent<AudioSource>().Play();
	}
}
