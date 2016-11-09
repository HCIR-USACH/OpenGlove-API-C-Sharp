using UnityEngine;
using UnityEngine.SceneManagement;

public class FullScreenObject : MonoBehaviour
{

	public void OnTriggerEnter(Collider other)
	{
		var grabbableObject = other.gameObject.GetComponent<GrabbableObject>();

		if (grabbableObject == null)
			return;

        if (grabbableObject.IsGrabbed())
			grabbableObject.SetFullScreenMode(true);
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("TestScene");
		}
	}
}
