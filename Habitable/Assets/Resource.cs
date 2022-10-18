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
        resourceType.resourcetype();
    }

    public void setResourceType(ResourceType _newResourcetype)
    {
        resourceType = _newResourcetype;
    }

    void rarity()
    {

    }
}

public interface ResourceType 
{
    public void resourcetype();
}
public class TypeA : ResourceType
{
    public void resourcetype()
    {
        Debug.Log("Type A");
    }
}
public class TypeB : ResourceType
{
    public void resourcetype()
    {
        Debug.Log("Type B");
    }
}
public class TypeC : ResourceType
{
    public void resourcetype()
    {
        Debug.Log("Type C");
    }
}
