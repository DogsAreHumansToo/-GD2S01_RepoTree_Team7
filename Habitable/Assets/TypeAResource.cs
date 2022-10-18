using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeAResource : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        TypeAClass typeAResource = new TypeAClass();
        setResourceType(typeAResource);
    }

  
}
