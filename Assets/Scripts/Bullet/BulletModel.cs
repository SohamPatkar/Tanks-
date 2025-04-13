using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel
{
    public float chargeSpeed;
    public GameObject fireTransform;

    public BulletModel(float chargeSpeed, GameObject fireTransform)
    {
        this.chargeSpeed = chargeSpeed;
        this.fireTransform = fireTransform;
    }
}


