using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//child of the resource class that is the acutal resource type
//initializes the different type then sets that as its type through
//the function from the parent class
public class TypeBResource : Resource
{
    // Start is called before the first frame update
    void Start()
    {
        TypeBClass typeBResource = new TypeBClass();
        setResourceType(typeBResource);
       

    }

}
