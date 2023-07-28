using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingInHouse : MonoBehaviour
{
    public GameObject Player;
    private bool playerEntered;
    // Start is called before the first frame update
    void Start()
    {
        playerEntered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
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
    }
}
