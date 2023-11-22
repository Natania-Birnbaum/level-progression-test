using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorController : MonoBehaviour
{
	Renderer indicatorRenderer;
	Animator animator;
	TimerController timer;
	
	// Start is called before the first frame update
    void Start()
    {
        indicatorRenderer = gameObject.transform.GetChild(1).GetComponent<Renderer>();
		animator = GetComponent<Animator>();
		timer = GameObject.Find("Timer").GetComponent<TimerController>();		
    }

    // Update is called once per frame
    void Update()
    {
		if (timer.timerActive) {
			animator.SetBool("TimerActive", true);
			indicatorRenderer.material.SetColor("_Color", Color.green);
		}
		else {
			animator.SetBool("TimerActive", false);
			indicatorRenderer.material.SetColor("_Color", Color.red);
		}		
    }
}
