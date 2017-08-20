using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] 

public class MyObject : MonoBehaviour {


	public Vector3 position;
	public Vector3 rotation;
	public Texture tx;
	public string name1;
	public Vector3 cff;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = position;
		this.guiTexture = tx;
	}
}
