using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//child of the resource class that is the acutal resource type
//initializes the different type then sets that as its type through
//the function from the parent class
public class TypeDResource : Resource
{
    void Start()
    {
        TypeDClass typeDResource = new TypeDClass();
        setResourceType(typeDResource);
    }

}
