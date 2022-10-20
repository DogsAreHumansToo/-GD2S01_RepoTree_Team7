using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCResource : Resource
{
    void Start()
    {
        TypeCClass typeCResource = new TypeCClass();
        setResourceType(typeCResource);
    }

}
