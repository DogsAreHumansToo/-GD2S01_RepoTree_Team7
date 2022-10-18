using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCResource : Resource
{
    void Start()
    {
        TypeC typeCResource = new TypeC();
        setResourceType(typeCResource);
    }

}
