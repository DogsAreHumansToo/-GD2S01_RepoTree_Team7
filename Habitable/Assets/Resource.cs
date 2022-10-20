using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    ResourceType resourceType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resourceType.Resourcetype();
    }

    public void setResourceType(ResourceType _newResourcetype)
    {
        resourceType = _newResourcetype;
    }

    
}





