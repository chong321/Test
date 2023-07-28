using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90);
        
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);


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

                if(target !=null)
                {
                    target.goIntoPC();
                }
            }
        }
    }

    void OnGUI()
    {
        int size = 12;

        // centre of screen and caters for font size
        float posX = cam.pixelWidth / 2 - size / 4;
        float posY = cam.pixelHeight / 2 - size / 2;

        // displays "*" on screen
        GUI.Label(new Rect(posX, posY, size, size), "");
    }
}
