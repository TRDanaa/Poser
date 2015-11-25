using UnityEngine;
using System.Collections;

public class testrandom : MonoBehaviour {
Animator animator;
void Awake(){
	}
	
	// Use this for initialization
	void Start () {
	
		Animation roll = animator.GetComponent<Animation>();
		roll["roll"].time = 0.5f;
		roll["roll"].speed = 0;
		}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
