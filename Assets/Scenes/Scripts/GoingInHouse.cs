using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingInHouse : MonoBehaviour
{
    public GameObject Player;
    public bool playerInOffice;
    // Start is called before the first frame update
    void Start()
    {
        playerInOffice = false;
    }

    public void goOffice()
    {
        
        Player.transform.position = new Vector3(64.65f, 1.17f, 35.49f);
        playerInOffice = true;
    }

    public void goHome()
    {
        
        Player.transform.position = new Vector3(62.168f, 1.17f, 61.84f);
        playerInOffice = false;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Door" && !playerEntered)
        {
            playerEntered = true;
            Player.transform.position = new Vector3(36.14f, 1.28f, 46.87f);
        }
        else if (other.tag == "Door" && playerEntered)
        {
            Player.transform.position = new Vector3(38.28f, 1.28f, 46.87f);
            playerEntered = false;
        }
    }*/
}
