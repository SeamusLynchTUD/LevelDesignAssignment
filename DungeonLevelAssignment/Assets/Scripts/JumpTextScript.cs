using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class JumpTextScript : MonoBehaviour
{
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            gameObject.SetActive(false);
            timer = 0;
        }
    }
}
