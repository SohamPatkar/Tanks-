using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletController
{
    private BulletModel bulletModel;
    private BulletView bulletView;

    public BulletController(BulletModel bulletModel, BulletView bulletView)
    {
        this.bulletModel = bulletModel;
        this.bulletView = GameObject.Instantiate(bulletView.gameObject, bulletModel.fireTransform.transform).GetComponent<BulletView>(); 

        this.bulletView.SetTankController(this);
    }

    public void BulletSpeed(GameObject fireTransformObject, float chargeSpeed)
    {
        Rigidbody shell = bulletView.gameObject.GetComponent<Rigidbody>();
        shell.velocity = fireTransformObject.transform.forward * chargeSpeed;
    }

    public GameObject GetFireTransform()
    {
        return bulletModel.fireTransform;
    }

    public float GetFireSpeed()
    {
        return bulletModel.chargeSpeed;
    }
}


