using System;
using UnityEngine;

public class DetectBone : MonoBehaviour
{
	public event Action OnTouch;
	public event Action OnStopTouch;

	public void OnTriggerEnter()
	{
		if (OnTouch != null)
			OnTouch();
	}

	public void OnTriggerExit()
	{
		if (OnStopTouch != null)
			OnStopTouch();
	}
}
