using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour {

	public float scrollingSpeed = 0.5f;
	void Start () {
		
	}
	void Update () {
		Vector2 offset = new Vector2 (Time.time * scrollingSpeed, 0);

		this.gameObject.GetComponent <MeshRenderer> ().material.mainTextureOffset = offset;
	}
}
