using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeDResource : Resource
{
    void Start()
    {
        TypeDClass typeDResource = new TypeDClass();
        setResourceType(typeDResource);
    }

}
