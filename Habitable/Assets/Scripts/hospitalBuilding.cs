using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hospitalBuilding : BuildingParentClass
{
    void Start()
    {
        TypeDClass resourceD = new TypeDClass();
        setResourceNeeded(resourceD);
        PassiveBuildingType passiveType = new PassiveBuildingType();
        setBuildingType(passiveType);
    }
}

