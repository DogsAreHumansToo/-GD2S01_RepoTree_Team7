using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class that calls from the parent interface that defines the
//resourcetype function. Debug log states what type of resource this is
public class TypeDClass : ResourceType
{
    public void Resourcetype()
    {
        Debug.Log("Type D");
    }
}
