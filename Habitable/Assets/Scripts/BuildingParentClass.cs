using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuildingParentClass : MonoBehaviour
{
    //Initializing the resource type interface
    BuildingType buildingType;
    ResourceType resourceNeeded;
    int numOfResourcesNeeded;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //calling the BuildingFunction function via the interface
        buildingType.BuildingType();
        Debug.Log("Resource Needed to build this building is"); 
        resourceNeeded.Resourcetype();
    }
    //function thats sets the resource type
    public void setBuildingType(BuildingType _newBuildingtype)
    {
        buildingType = _newBuildingtype;
    }
    public void setResourceNeeded(ResourceType _resourceNeeded)
    {
        for (  int i = 1; i < numOfResourcesNeeded; i++)
        {
            resourceNeeded = _resourceNeeded;

        }
    }

    void produceGoods()
    {

    }


}
