using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pose : MonoBehaviour {

Animator animator;
private bool standingPoses = false;
private bool movingPoses = false;
public Transform RandomizeButton; 
	
	void Awake(){
	
	 animator = GetComponent<Animator>();
}


	public void RandomizePoses(){
		
		if (RandomizeButton.GetComponent<Button>().IsInteractable() == true)
		{
			
			RandomizeButton.GetComponent<Button>().interactable = true; 
			if(standingPoses == true) // STANDING POSES
				{
				
				print("Randomize-click");
			
				animator.SetFloat("Standing", Random.Range(0.0f, 1.0f));	
				RandomizeButton.GetComponent<Button>().interactable = true; 

						}
			
			 if(movingPoses == true) // MOVING POSES
			{
				
				print("Randomize-click");
				animator.SetFloat("Moving", Random.Range(0.0f, 1.0f));	
				RandomizeButton.GetComponent<Button>().interactable = true; 
				
				
			}
		}
	}
		
		
	
	
	public void StandingPosesToggle(string name)
		{
		standingPoses = GUI.Toggle(new Rect(10, 10, 100, 30), standingPoses, "A Toggle text");
			if (standingPoses == false)
			{
				standingPoses = true;
				{print("Standing-true");}
			}
			else if (standingPoses == true)
			{
				standingPoses = false;
				{print("Standing-false");}
				
			}
		}
		
		
	public void MovingPosesToggle(string name)
	{
		movingPoses = GUI.Toggle(new Rect(10, 10, 100, 30), movingPoses, "A Toggle text");
		if (movingPoses == false)
		{
			movingPoses = true;
			{print("Moving-true");}
		}
		else if (movingPoses == true)
		{
			movingPoses = false;
			{print("Moving-false");}
			
		}
	}
	}
		
		
		
		
		
		
	

			
			
			
			
			
			
			
			
			
			
			
		
	
	

