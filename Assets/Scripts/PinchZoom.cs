using UnityEngine;
using System.Collections;
public class PinchZoom : MonoBehaviour
{
	public int speed = 4;
	public Camera selectedCamera;
	public float minPinchSpeed = 5.0F;
	public float varianceInDistances = 5.0F;
	private float touchDelta = 0.0F;
	private Vector2 prevDist = new Vector2(0, 0);
	private Vector2 curDist = new Vector2(0, 0);
	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
		{
			curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
			prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions
			touchDelta = curDist.magnitude - prevDist.magnitude;
			//speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;
			//speedTouch1 = Input.GetTouch(1).deltaPosition.magnitude / Input.GetTouch(1).deltaTime;
			
			if ((touchDelta <= 1))
			{
				Debug.Log("Zoom In");
				selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView + (1 * speed), 15, 90);
			}
			if ((touchDelta > 1))
			{
				Debug.Log("Zoom Out");
				selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView - (1 * speed), 15, 90);
			}
		}
	}
}
