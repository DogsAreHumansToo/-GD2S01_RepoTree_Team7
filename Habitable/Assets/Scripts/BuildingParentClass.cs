using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BuildingParentClass : MonoBehaviour
{
    //Initializing the resource type interface
    BuildingType buildingType;
    ResourceType resourceType;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //calling the BuildingFunction function via the interface
        buildingType.BuildingFunction();
    }
    //function thats sets the resource type
    public void setBuildingType(BuildingType _newBuildingtype)
    {
        buildingType = _newBuildingtype;
    }
    public void setBuildingType(ResourceType _resourceNeeded)
    {

    }
    void produceGoods()
    {

    }


}
