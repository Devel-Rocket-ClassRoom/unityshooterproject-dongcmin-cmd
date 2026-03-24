using System;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{

    public GameObject projectile;
    public Transform spawnPoint;
    public float Power;
    public GameObject Cannon;

    private GameObject p1;
    protected GameObject p2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //만약에 마우스 좌클릭 누르면
        if(Input.GetMouseButtonDown(0) == true)
        {
            // 발사
            GameObject obj = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.linearVelocity = spawnPoint.up * Power;
            }


        }
        
        if (Input.GetMouseButtonDown(1) == true)
        {
            
            GameObject obj = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.useGravity = false;
            
             if(rb != null)
            {
                rb.linearVelocity = spawnPoint.up * Power;
            }
        }

        float rotDir = 0;
        //만약에 w키를 누르면 포탑이 올라감
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            rotDir = 1;

        }
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            rotDir = -1;
        }
        transform.localRotation *= Quaternion.Euler(0f, 0f,  rotDir * 1.0f);
        float rotDir2 = 0;
        //만약에 w키를 누르면 포탑이 올라감
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            rotDir2 = 1;

        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            rotDir2 = -1;
        }
        transform.localRotation *= Quaternion.Euler(rotDir2 * 1.0f, 0f, 0f);

        //블럭 프리팹 만들고 for문을 이용해 가로 50,세로20개

        //1. 만약에 a 누르면 왼쪽, 오른쪽
        // transgorm 사용하면 현재 스크립트 오브젝트 변경..
        //transform.position = new Vector3(transform.position.x, transform.position.y, z)


        // 만약 목표물과 포탄이 충돌하면 로그출력
        float h1 = Input.GetAxis("Mouse X");
        float v1 = Input.GetAxis("Mouse Y");
        //Debug.Log("Mouse X:" + h1 + ", Mouse Y:" + v1);

        //transform.localRotation *= Quaternion.Euler(0f, 0f, 0f);
        //transform.Rotate(Vector3.up * v1);
        transform.localRotation *= Quaternion.Euler(0f, 0f, v1 * 4.0f);

        //transform.Rotate(Vector3.right * -v1);
        //Cannon.transform.Rotate(Vector3.right * v1 * 2.0f);
        //transform.Rotate(Vector3.up * h1 * 2.0f);


        //질문1 부모 자식되면 따로 보기 불편?


    }
}
