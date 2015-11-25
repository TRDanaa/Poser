/*using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pose : MonoBehaviour {

Animator animator;
private bool standingPoses = true;
	public Transform button; 
	
	void Awake(){
	
	 animator = GetComponent<Animator>();
}


	public void RandomizePoses(){
		//if(GUI.Button(new Rect(10,10,150,100), "Randomize")) 
		if (button.GetComponent<Button>().IsInteractable() == true)
		{
			button.GetComponent<Button>().interactable = true; 
			print("falase");
			
			animator.SetFloat("Standing", Random.Range(0.0f, 1.0f));	
			}
		}
		
	
	
	public void StandingPosesToggle(string name)
		{
		standingPoses = GUI.Toggle(new Rect(10, 10, 100, 30), standingPoses, "A Toggle text");
			if (standingPoses == false)
			{
				standingPoses = true;
				{print("true");}
			}
			else if (standingPoses == true)
			{
				standingPoses = false;
				{print("false");}
				
			}
		}
	}
		
		*/
		
		
		
		
	

			
			
			
			
			
			
			
			
			
			
			
		
	
	

