using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerraformingBuilding : BuildingParentClass
{
    void Start()
    {
        TypeDClass resourceD = new TypeDClass();
        TypeCClass resourceC = new TypeCClass();
        setResourceNeededComplex(resourceC,resourceD);
        ActiveBuildingType activeType = new ActiveBuildingType();
        setBuildingType(activeType);
    }
}
