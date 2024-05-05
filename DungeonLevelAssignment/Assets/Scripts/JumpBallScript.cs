using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;

public class JumpBallScript : MonoBehaviour
{
    public GameObject JumpText;
    public FirstPersonController firstPersonController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        firstPersonController.JumpHeight += 1.2f;
        Destroy(gameObject);
        Debug.Log("Ball destroyed");
        Debug.Log(firstPersonController.JumpHeight);
        JumpText.SetActive(true);
    }
}
