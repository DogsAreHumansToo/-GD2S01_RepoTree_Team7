using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//parent resource class
public class Resource : MonoBehaviour
{
    //Initializing the resource type interface
    ResourceType resourceType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calling the Resourcetype function via the interface
        resourceType.Resourcetype();
    }
    //function thats sets the resource type
    public void setResourceType(ResourceType _newResourcetype)
    {
        resourceType = _newResourcetype;
    }

    
}





