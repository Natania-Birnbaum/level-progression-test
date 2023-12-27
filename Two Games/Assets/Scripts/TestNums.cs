using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNums : MonoBehaviour
{
	TextHandler data;
	float[] nums0;
	
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("TextHandler").GetComponent<TextHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        nums0 = data.nums;
		
		Debug.Log("nums0: " + data.GetComponent<TextHandler>().nums[5]);
		
    }
}
