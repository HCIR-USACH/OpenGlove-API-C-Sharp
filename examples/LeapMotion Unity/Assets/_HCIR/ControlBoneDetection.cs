using System.Collections.Generic;
using UnityEngine;

public class ControlBoneDetection : MonoBehaviour
{
	[Header("Index")]
	public DetectBone indexBone1;
	public DetectBone indexBone2;
	public DetectBone indexBone3;

	[Header("Middle")]
	public DetectBone middleBone1;
	public DetectBone middleBone2;
	public DetectBone middleBone3;

	[Header("Palm")]
	public DetectBone palmBone;

	[Header("Pinky")]
	public DetectBone pinkyBone1;
	public DetectBone pinkyBone2;
	public DetectBone pinkyBone3;

	[Header("Ring")]
	public DetectBone ringBone1;
	public DetectBone ringBone2;
	public DetectBone ringBone3;

	[Header("Thumb")]
	public DetectBone thumbBone1;
	public DetectBone thumbBone2;
	public DetectBone thumbBone3;

	[Space(10)]
	public UnityHapticGlove Uglove;
	public string impact = "255" ;

	public void Start()
	{
		indexBone3.OnTouch += () => { Uglove.ActivateMotorIndex(impact); };
		indexBone3.OnStopTouch += Uglove.DeactivateMotorIndex;

        middleBone3.OnTouch += () => {Uglove.ActivateMotorMiddle(impact); };
        middleBone3.OnStopTouch += Uglove.DeactivateMotorMiddle;

        pinkyBone3.OnTouch += () => { Uglove.ActivateMotorPinky(impact); };
        pinkyBone3.OnStopTouch += Uglove.DeactivateMotorPinky;

        ringBone3.OnTouch += () => { Uglove.ActivateMotorRing(impact); };
        ringBone3.OnStopTouch += Uglove.DeactivateMotorRing;

        thumbBone3.OnTouch += () => { Uglove.ActivateMotorThumb(impact); };
        thumbBone3.OnStopTouch += Uglove.DeactivateMotorThumb;

        palmBone.OnTouch += () => { Uglove.ActivateMotorPalm(impact); };
        palmBone.OnStopTouch += Uglove.DeactivateMotorPalm;
    }
}
