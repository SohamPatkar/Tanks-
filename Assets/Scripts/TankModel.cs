using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    private TankController tankController;
    
    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankType;
    public Material tankColor;

    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankType, Material _tankColor)
    {
        this.movementSpeed = _movementSpeed;
        this.rotationSpeed = _rotationSpeed;
        this.tankType = _tankType;
        this.tankColor = _tankColor;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
