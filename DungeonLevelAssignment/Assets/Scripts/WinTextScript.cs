using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTextScript : MonoBehaviour
{
    public GameObject WinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        WinText.SetActive(true);
        Destroy(gameObject);
    }
}
