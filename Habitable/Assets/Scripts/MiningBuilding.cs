using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiningBuilding : BuildingParentClass
{
    void Start()
    {
        TypeAClass resourceA = new TypeAClass();
        setResourceNeeded(resourceA);
        PassiveBuildingType passiveType = new PassiveBuildingType();
        setBuildingType(passiveType);
    }
}
