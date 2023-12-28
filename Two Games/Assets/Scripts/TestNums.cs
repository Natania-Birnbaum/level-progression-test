using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNums : MonoBehaviour
{
	public TextHandler data;
	float[] nums0;
	
    // Start is called before the first frame update
    void Start()
    {
        //data = GameObject.Find("TextHandler").GetComponent<TextHandler>();
		Debug.Log("Test Start");
    }

    // Update is called once per frame
    void Update()
    {
        nums0 = data.nums;
		
		Debug.Log("nums0: " + nums0[5]);
		
    }
}
