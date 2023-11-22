using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextHandler : MonoBehaviour
{
    string path = "Assets/" + "test.csv";
	StreamReader reader;
	public float[] nums;
	
	float[] ParseString(string str) {
		
		string[] spl = str.Split(",");
		int l = spl.Length;
		float[] arr = new float[l];
		
		for (int i = 0; i < l; i++) {
			arr[i] = float.Parse(spl[i]);
		}
		
		return arr;
	}
	
	// Start is called before the first frame update
    void Start()
    {
		reader = new StreamReader(path);
    }

    // Update is called once per frame
    void Update()
    {
        //Read the text from directly from the test.csv file
		string line = reader.ReadLine();
		Debug.Log(line);
		
		nums = ParseString(line);

    }
}
