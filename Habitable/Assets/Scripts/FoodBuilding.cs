using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBuilding : BuildingParentClass
{
    void Start()
    {
        TypeBClass resourceB = new TypeBClass();
        setResourceNeeded(resourceB);
        PassiveBuildingType passiveType = new PassiveBuildingType();
        setBuildingType(passiveType);
    }
}
