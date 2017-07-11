using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTierra : MonoBehaviour {

	public float velocidad;
	public float zAxis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, velocidad, zAxis));
	}
}
