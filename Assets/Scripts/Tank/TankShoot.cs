using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankShoot : MonoBehaviour
{
    [SerializeField] private BulletView bulletObject;
    [SerializeField] private GameObject fireTransformObject;
    [SerializeField] private Slider aimSlider;
    [SerializeField] private ParticleSystem smokeParticleSystem;

    private float chargeSpeed;
    private float minChargeSpeed;
    private float maxChargeSpeed;
    private bool fired;

    //add particle system

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        if (Input.GetButtonUp("Fire1") && !fired)
        {
            Fire();
            chargeSpeed = 15f;
            aimSlider.value = 15f;
        }
        else if(Input.GetButton("Fire1") && !fired)
        {
            chargeSpeed += minChargeSpeed * Time.deltaTime;

            aimSlider.value = chargeSpeed;
        }
        else if(Input.GetButton("Fire1") && !fired && chargeSpeed >= maxChargeSpeed)
        {
            chargeSpeed = maxChargeSpeed;
        }
    }

    private void Init()
    {
        minChargeSpeed = 15f;
        maxChargeSpeed = 30f;
        chargeSpeed = minChargeSpeed;
        fired = false;
    }

    private void Fire()
    {
        fired = true;
        BulletModel bullet = new BulletModel(chargeSpeed, fireTransformObject);
        BulletController controller = new BulletController(bullet, bulletObject);
        SoundManager.Instance.PlaySfxSound(SoundType.SHOTFIRED);
        smokeParticleSystem.Play();
        fired = false;
    }
}
