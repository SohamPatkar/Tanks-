using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    [SerializeField] private ParticleSystem trailsParticleSystem;
    [SerializeField] private Rigidbody rb;

    private GameObject cam;

    public MeshRenderer[] tankBody;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        CameraFollow();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        trailsParticleSystem.Stop();

        if(movement != 0)
        {
            tankController.Movement(movement);
        }

        if (rotation != 0)
        {
            tankController.Rotation(rotation);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public void CameraFollow()
    {
        cam.transform.SetParent(this.gameObject.transform);
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    public void SetColor(Material color)
    {
        for(int i = 0; i< tankBody.Length; i++)
        {
            tankBody[i].material = color;
        }
    }

    public void PlayParticleSystem()
    {
        trailsParticleSystem.Play();
    }
}
