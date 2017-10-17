using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;


	public bool bounds;

	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;


	//Update

	void Update () {
		if (target) {

			Vector3 point = GetComponent<Camera> ().WorldToViewportPoint (target.position);

			Vector3 delta = target.position - GetComponent<Camera> ().ViewportToWorldPoint (new Vector3 (.50f, .50f, point.z));

			Vector3 destination = transform.position + delta;

			transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, dampTime);


			if (bounds) {

				transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x), Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y), Mathf.Clamp (transform.position.z, minCameraPos.z, maxCameraPos.z));
			}
		}
	}
}