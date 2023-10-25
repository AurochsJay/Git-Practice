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
        Vector3 direction = new Vector3(1f, 2f, 3f);
        rigidBody.AddForce(direction);
        rigidBody.velocity *= 2f * Time.deltaTime;
    }

    //asfasdfasdfasdfasd;

    //�̰��� �����̰� ������� ��ũ��Ʈ
    //���� �������� �ʾҰ���
    //�˼� ���� ��ũ��Ʈ�� ���������߰ڴ�.
    //������ �����ֱ���
    //������

}
