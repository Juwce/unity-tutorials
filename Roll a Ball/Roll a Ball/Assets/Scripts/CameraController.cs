using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = offset = transform.position - player.transform.position;
	}
	
	// Use late update so we know absolutely that the player has moved for this frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
