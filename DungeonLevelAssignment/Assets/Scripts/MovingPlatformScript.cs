using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    public GameObject position1;
    public GameObject position2;
    public float Speed;
    private bool backAndForth = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(backAndForth)
        {
            case false:
                transform.position = Vector3.MoveTowards(transform.position, position1.transform.position, Speed * Time.deltaTime);
                //Debug.Log(backAndForth);
                //Debug.Log(position1.transform.position);
                break;
            case true:
                transform.position = Vector3.MoveTowards(transform.position, position2.transform.position, Speed * Time.deltaTime);
                //Debug.Log(backAndForth);
                //Debug.Log(position2.transform.position);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Position")
        {
            switch (backAndForth)
            {
                case false:
                    backAndForth = true;
                    break;
                case true:
                    backAndForth = false;
                    break;
            }
        }
    }
}
