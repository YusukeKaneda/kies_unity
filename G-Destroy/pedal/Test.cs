using UnityEngine;
using System.Collections;
//using System.IO.Ports;
using System.Runtime.InteropServices;

public class Test : MonoBehaviour {
	public static G_Serial.Class1 serial;
	public static int r = 0;

	void Start()
	{
		serial = new G_Serial.Class1 ("COM9", 9600, 512);
		serial.ThreadStart ();
	}

	void Update()
	{
		string str = serial.GetData ();
		if (str != null) {
			r = int.Parse (str);

		}
		Debug.Log (r);
	}

	void OnDestroy()
	{
		serial.ThreadEnd ();
	}
}