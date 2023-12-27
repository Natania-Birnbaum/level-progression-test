using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
	TextMeshPro mesh;
	float[] speed;
	float[] fractionation;
		
	string s;
	string f;
	
    // Start is called before the first frame update
    void Start()
    {
		speed = GameObject.Find("Hand").GetComponent<CalculateParameters>().speed;
		fractionation = GameObject.Find("Hand").GetComponent<CalculateParameters>().fractionation;
		
        mesh = GetComponent<TextMeshPro>();
		mesh.text = string.Format("Speed: {0}\nFractionation: {1}", speed, fractionation);
    }

    // Update is called once per frame
    void Update()
    {
		s = "";
		foreach (float i in speed) {
			s += Math.Abs(i).ToString("0.00") + " ";
		}
		f = "";
		foreach (float i in fractionation) {
			f += Math.Abs(i).ToString("0.00") + " ";
		}
		
		mesh.text = string.Format("Speed: {0}\nFractionation: {1}", s, f);
    }
	
	float movingAverage(int window, int ix, float[] data) {
		float[] f = new float[window];
		return 0f;
	}
}
