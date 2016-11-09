using UnityEngine;
using System.Collections;

public class HoveringObject : MonoBehaviour
{
	public Transform startMarker;
	public Transform endMarker;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	private float distance;

	public void Start()
	{
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		distance = endMarker.position.y - startMarker.position.y;
	}

	public void Update()
	{
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);

		if (transform.position.y != endMarker.position.y)
			return;
		Debug.Log("endmarker reached");

		var oldPosition = endMarker.position;
		endMarker.position = new Vector3(oldPosition.x, oldPosition.y - (distance * 2), oldPosition.z);
	}
}
