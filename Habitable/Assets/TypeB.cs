using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeBResource : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        TypeB typeBResource = new TypeB();
        setResourceType(typeBResource);
    }

}
