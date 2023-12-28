using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
	public float time;
	public float timeLimit;
	public float rest;
	public bool timerActive;
	
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
		timeLimit = 2.5f;
		rest = 3.5f;
		timerActive = false;
    }

    // Update is called once per frame
    void Update()
    {
		time += Time.deltaTime;
		
        if (timerActive && time > timeLimit) {
			time = 0;
			timerActive = false;
		}
		if (!timerActive && time > rest) {
			time = 0;
			timerActive = true;
		}
    }
}
