using UnityEngine;
using System.Collections;

public class daycycle : MonoBehaviour {
	[Tooltip ("Number of minutes per second that pas, try 60")]
	public float minutesPerSecond;
	private Quaternion starRotation;
	
	// Use this for initialization
	void Start () {
		starRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	
		float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround (transform.position, Vector3.forward, angleThisFrame);
	
	}
}
