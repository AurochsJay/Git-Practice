using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kangminscript : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(11f, 14f, 29f);
        rigidBody.AddForce(direction);
        rigidBody.velocity *= 0xAf * Time.deltaTime;
    }

    void test()
    {
        float abc;
        abc*=23;
        // i boom

        return;
    }

    public float ChangeFloat(float a, float b)
    {
        float something = a + b;
        return something;
    }


}
