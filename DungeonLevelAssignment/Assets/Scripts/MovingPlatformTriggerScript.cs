using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatformTriggerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject OtherParent;
    public GameObject Platform;
    private bool OnPlatform = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Platform.transform.position;
        switch(OnPlatform)
        {
            case false:
                break;
            case true:
                Player.transform.position += Platform.transform.position;
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (other.tag == "Player")
        {
            Player.transform.parent = Platform.transform;
            OnPlatform = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        if (other.tag == "Player")
        {
            Player.transform.parent = OtherParent.transform;
            OnPlatform = false;
        }
    }
}
