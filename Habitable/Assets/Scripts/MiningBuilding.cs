using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningBuilding : BuildingParentClass
{
    void Start()
    {
        TypeAClass resourceA = new TypeAClass();
        TypeBClass resourceB = new TypeBClass();
        setResourceNeededComplex(resourceA, resourceB);
        PassiveBuildingType passiveType = new PassiveBuildingType();
        setBuildingType(passiveType);
    }
}
