using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityHapticGlove : MonoBehaviour {
	
	private HapticsGlove.HapticsGlove glove;
	private List<int> positivePins;
    private List<int> negativePins;
    private List<int> index;
    private List<int> middle;
    private List<int> thumb;
    private List<int> pinky;
    private List<int> ring;
    private List<int> palm;
    private List<string> valuesOFF;

    public void Start()
	{
		positivePins = new List<int>() { 11, 10, 9, 6, 5, 3 };
        negativePins = new List<int>() { 16, 15, 14, 12, 8, 2 };
        valuesOFF = new List<string>() { "LOW", "LOW", "LOW", "LOW", "LOW", "LOW" };
        index = new List<int>() {9 };
        middle = new List<int>() {6 };
        thumb = new List<int>() { 10};
        pinky = new List<int>() { 3};
        ring = new List<int>() { 5};
        palm = new List<int>() { 11};

        glove = new HapticsGlove.HapticsGlove();

		Debug.Log("Haptics Glove Output");
		foreach (var portName in glove.GetPortNames())
		{
			Debug.Log(portName);
		}
        Debug.Log(glove.GetPortNames());
        glove.OpenPort("COM25", 57600);
        System.Threading.Thread.Sleep(2000);
        glove.InitializeMotor(positivePins);
        glove.InitializeMotor(negativePins);
        glove.ActivateMotor(negativePins, valuesOFF);
        glove.ActivateMotor(negativePins, valuesOFF);

        Debug.Log("Ports Open");
	}

    public void ActivateMotorIndex(string impact)
    {
        Debug.Log("activated");
        glove.ActivateMotor(index, new List<string>() { impact });
    }

    public void DeactivateMotorIndex()
    {
        Debug.Log("de-activated");
        glove.ActivateMotor(index, new List<string>() { "0" });
    }
    public void ActivateMotorMiddle(string impact)
	{
		Debug.Log("activated");
		glove.ActivateMotor(middle, new List<string>() { impact });
	}

	public void DeactivateMotorMiddle()
	{
		Debug.Log("de-activated");
		glove.ActivateMotor(middle, new List<string>() { "0" });
	}

    public void ActivateMotorThumb(string impact)
    {
        Debug.Log("activated");
        glove.ActivateMotor(thumb, new List<string>() { impact });
    }

    public void DeactivateMotorThumb()
    {
        Debug.Log("de-activated");
        glove.ActivateMotor(thumb, new List<string>() { "0" });
    }

    public void ActivateMotorPinky(string impact)
    {
        Debug.Log("activated");
        glove.ActivateMotor(pinky, new List<string>() { impact });
    }

    public void DeactivateMotorPinky()
    {
        Debug.Log("de-activated");
        glove.ActivateMotor(pinky, new List<string>() { "0" });
    }

    public void ActivateMotorRing(string impact)
    {
        Debug.Log("activated");
        glove.ActivateMotor(ring, new List<string>() { impact });
    }

    public void DeactivateMotorRing()
    {
        Debug.Log("de-activated");
        glove.ActivateMotor(ring, new List<string>() { "0" });
    }

    public void ActivateMotorPalm(string impact)
    {
        Debug.Log("activated");
        glove.ActivateMotor(palm, new List<string>() { impact });
    }

    public void DeactivateMotorPalm()
    {
        Debug.Log("de-activated");
        glove.ActivateMotor(palm, new List<string>() { "0" });
    }
}
