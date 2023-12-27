using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateParameters : MonoBehaviour
{
	//store incoming datastream
    GameObject data;
	float[] nums = new float[22];
	
	//store parameters for each finger
	public float[] speed = new float[5];
	public float[] deltaSpeed = new float[5];
	public float[] fractionation = new float[5];
	
	//store current and previous states
	int cur = 0;
	float[] prevState = {146,121,113,128,117,95,65,97,108,75,152,110,88,69,148,114,116,83,140,131,135,115};
	float[] prevSpeed = new float[22];
	
    // Start is called before the first frame update
    void Start()
    {
		//get raw data from port
        data = GameObject.Find("TextHandler");
    }

    // Update is called once per frame
    void Update()
    {
        //reset speed and fractionation arrays
		for (int i = 0; i < 5; i++) {
			speed[i] = 0;
			fractionation[i] = 0;
		}
		
		nums = data.GetComponent<TextHandler>().nums;
		
		for (int i = 0; i < 22; i++) {
		
			//difference between current and previous data point
			float dis = nums[i] - prevState[i];
			prevState[i] = nums[i];
			
			//set current finger
			if (i <= 3) {
				cur = 0;
			}
			else if (i >= 4 && i <= 6) {
				cur = 1;
			}
			else if (i >= 7 && i <= 9) {
				cur = 2;
			}
			else if (i >= 11 && i <= 13) {
				cur = 3;
			}
			else if (i >= 15 && i <= 17) {
				cur = 4;
			}
			
			//record speed
			speed[cur] += dis;
			
			//record speed change
			deltaSpeed[cur] = speed[cur] - prevSpeed[cur];
			prevSpeed[cur] = speed[cur];
		
			//record fractionation
			for (int j = 0; i < 5; j ++) {
				
			}
			fractionation[cur] = 0;
		}
    }
}
