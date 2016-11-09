using UnityEngine;
using System.Collections;

public class GrabbableObject : MonoBehaviour
{
	#region Public Fields

	public bool useAxisAlignment = false;
	public Vector3 rightHandAxis;
	public Vector3 objectAxis;

	public bool rotateQuickly = true;
	public bool centerGrabbedObject = false;

	public Rigidbody breakableJoint;
	public float breakForce;
	public float breakTorque;

	#endregion

	#region Protected Fields

	protected bool grabbed_ = false;
	protected bool hovered_ = false;
	protected bool fullScreenMode_ = false;

	#endregion

	#region Virtual Methods

	public virtual void OnStartHover()
	{
		hovered_ = true;
	}

	public virtual void OnStopHover()
	{
		hovered_ = false;
	}

	public virtual void OnGrab()
	{
		grabbed_ = true;
		hovered_ = false;

		if (breakableJoint != null)
		{
			Joint breakJoint = breakableJoint.GetComponent<Joint>();
			if (breakJoint != null)
			{
				breakJoint.breakForce = breakForce;
				breakJoint.breakTorque = breakTorque;
			}
		}
	}

	public virtual void OnRelease() {
		grabbed_ = false;

		if (breakableJoint != null) {
			Joint breakJoint = breakableJoint.GetComponent<Joint>();
			if (breakJoint != null) {
				breakJoint.breakForce = Mathf.Infinity;
				breakJoint.breakTorque = Mathf.Infinity;
			}
		}
	}

	#endregion

	#region Public Methods

	public bool IsHovered() {
		return hovered_;
	}

	public bool IsGrabbed() {
		return grabbed_;
	}

	public bool IsFullScreenMode()
	{
		return fullScreenMode_;
	}

	public void SetFullScreenMode(bool value)
	{
		fullScreenMode_ = value;

		ChangeSize(value);
	}

	private void ChangeSize(bool makeBig)
	{
		GetComponent<Collider>().enabled = false;

		GetComponent<Rigidbody>().useGravity = false;
	}

	public void Update()
	{
		if (fullScreenMode_)
		{
			transform.position = new Vector3(
				-0.05f, 0.09f,
				-4.5f);

			transform.rotation = Quaternion.identity;
		}
	}

	#endregion
}
