using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateHand : MonoBehaviour
{
    GameObject data;
	float[] nums;
	
	Transform[] joints = new Transform[22];
	Vector3[] defaults = new Vector3[22];
	Vector3 currentAngles;
	
    // Use this for initialization
    void Start () {
		data = GameObject.Find("TextHandler");
		
		Transform wrist = gameObject.transform.GetChild(0).GetChild(0).GetChild(0);
		
		//thumb base - 003
		joints[0] = wrist.GetChild(0);
		//thumb joint 1 - 004
		joints[1] = joints[0].GetChild(0);
		//thumb joint 2 - 005
		joints[2] = joints[1].GetChild(0);
		//space between thumb and index
		joints[3] = null;
		//index joint 1 - 006
		joints[4] = wrist.GetChild(1);
		//index joint 2 - 007
		joints[5] = joints[4].GetChild(0);
		//index joint 3 - 008
		joints[6] = joints[5].GetChild(0);
		//middle joint 1 - 009
		joints[7] = wrist.GetChild(2);
		//middle joint 2 - 010
		joints[8] = joints[7].GetChild(0);
		//middle joint 3 - 011
		joints[9] = joints[8].GetChild(0);
		//space between index and middle
		joints[10] = null;
		//ring joint 1 - 012
		joints[11] = wrist.GetChild(3);
		//ring joint 2 - 013
		joints[12] = joints[11].GetChild(0);
		//ring joint 3 - 014
		joints[13] = joints[12].GetChild(0);
		//space between middle and ring
		joints[14] = null;
		//pinky joint 1 - 015
		joints[15] = wrist.GetChild(4);
		//pinky joint 2 - 016
		joints[16] = joints[15].GetChild(0);
		//pinky joint 3 - 017
		joints[17] = joints[16].GetChild(0);
		//space between ring and pinky
		joints[18] = null;
		//outside of hand
		joints[19] = null;
		//wrist  - 001
		joints[20] = wrist;
		//outside of wrist
		joints[21] = null;
		
		for (int i = 0; i < 22; i++) {
			defaults[i] = joints[i].localEulerAngles;
		}
		
    }
    
    // Update is called once per frame
    void Update () {
		nums = data.GetComponent<TextHandler>().nums;
		
		for (int i = 0; i < 22; i++) {
			Transform t = joints[i];
			Vector3 d = defaults[i];
			float num = nums[i]/2.5f;
			
			if (t != null) {
				currentAngles = t.localEulerAngles;
				
				if (i <= 3) {
					
				} else if (i % 3 == 0) {
					currentAngles.z = d.z + num;
				} else {
					currentAngles.x = d.x + num;
				}				
				
				t.localEulerAngles = currentAngles;
			}
		}		
    }
}