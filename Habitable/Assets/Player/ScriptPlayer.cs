using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    private float fspeed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime * fspeed, Space.World);
            Debug.Log("Player is moving up");
        }
        if (Input.GetKey("s"))
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime * -fspeed, Space.World);
            Debug.Log("Player is moving dows");
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * -fspeed, Space.World);
            Debug.Log("Player is moving left");
        }
        if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * fspeed, Space.World);
            Debug.Log("Player is moving right");
        }

    }
  
}
