using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    Camera cam;

	// Use this for initialization
	void Start () {
        cam = Camera.main;  //The camera tagged as "MainCamera"
        if (cam == null)
        {
            Debug.LogError("No camera attached to script.");
        }
    }
	
    void Awake()
    {
        
    }

	// Update is called once per frame
	void Update () {

        
        if (cam != null)
        {
            float xAxisValue = Input.GetAxis("Horizontal");
            float zAxisValue = Input.GetAxis("Vertical");

            /*Remove all but the Y axis rotation from the camera so it translates
              along the world's x and z axes rather than its own
            */
            Quaternion CurrentRotation = cam.transform.rotation;
            Vector3 ea = CurrentRotation.eulerAngles;
            cam.transform.rotation = Quaternion.Euler(0, ea.y, 0);

            //Perform the translation, then restore the original rotation
            cam.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
            cam.transform.rotation = CurrentRotation;

        }

        


    }
}
