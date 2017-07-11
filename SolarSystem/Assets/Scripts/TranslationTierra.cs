using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationTierra : MonoBehaviour {

	public float velocidad;
	public Transform pivot;

	void Update () {
		transform.RotateAround (pivot.position, Vector3.up, velocidad);
	}
}
