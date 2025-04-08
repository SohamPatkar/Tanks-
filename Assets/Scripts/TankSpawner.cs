using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private GameObject tankObject;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankObject, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World");
    }
}
