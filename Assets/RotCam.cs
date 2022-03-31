using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCam : MonoBehaviour
{
    public GameObject target;//the target object
    private float speedMod = 10.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at

    private float angle = 45f;
    
    // Start is called before the first frame update
    void Start()
    {
        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("right")){
            transform.RotateAround (target.transform.position, Vector3.up, 90);  
        } else if (Input.GetKeyUp("left")) {
            transform.RotateAround (target.transform.position, Vector3.up, -90);
        }
    }
}
