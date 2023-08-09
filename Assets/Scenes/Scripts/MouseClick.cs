using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

    [SerializeField]
    [Header("Camera Zoom Speed")]
    private float movementSpeed = 2.0f;

    private Camera cam;
    private RaycastHit _hit;



    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_hit.collider != null)
        {
            _hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);
        }
        var _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(_ray, out _hit))
        {
            _hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // get point in the middle of the screen
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);

            // create a ray from the point in the direction of the camera
            Ray ray = cam.ScreenPointToRay(point);

            RaycastHit hit; // stores ray intersection information
            if (Physics.Raycast(ray, out hit))
            {
                // get the GameObject that was hit
                GameObject hitObject = hit.transform.gameObject;

                OpenComputer target = hitObject.GetComponent<OpenComputer>();
                GoingInHouse enterOffice = hitObject.GetComponent<GoingInHouse>();

                if(hitObject.tag == "Computer")
                {
                    GetComponent<PlayerCam>().enabled = false;
                    transform.position = Vector3.Lerp(transform.position, hitObject.transform.position, movementSpeed);
                    transform.LookAt(hitObject.transform.position);
                    target.Invoke("goIntoPC", 1);
                }
                else if(hitObject.tag == "OfficeDoor")
                {  
                    enterOffice.goOffice();
                }
                else if(hitObject.tag == "HomeDoor")
                {  
                    enterOffice.goHome();
                }
                //GetComponent<PlayerCam>().enabled = true;
            }
        }
    }
}
