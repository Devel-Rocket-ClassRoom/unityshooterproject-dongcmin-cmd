using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;

    public Transform patrolPoint1;
    public Transform patrolPoint2;
    public Transform patrolPoint3;
    public Transform patrolPoint4;
    public float patrolSpeed = 2.0f;
    private Transform targetPoint;
    public Transform playerPosition;

    //public bool Damage0()
    //{
    //    //Player playerdamage = GetComponent<Player>();
    //    health -= player.damage;
    //    if (health <= 0)
    //    {
    //        return true;
    //    }

    //    return false;
    //}


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

            

        Vector3 pos = patrolPoint1.position;
        pos.y = transform.position.y;
        patrolPoint1.position = pos;

        pos = patrolPoint2.position;
        pos.y = transform.position.y;
        patrolPoint2.position = pos;

        targetPoint = patrolPoint1;






    }

    // Update is called once per frame
    void Update()
    {
        Patrol();

    }

    void Patrol()
    {
        //transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, patrolSpeed * Time.deltaTime);

        //if (Vector3.Distance(transform.position, targetPoint.position) < 0.05f)
        //{
        //    if (targetPoint == patrolPoint1)
        //        targetPoint = patrolPoint2;
        //    else
        //        targetPoint = patrolPoint1;

        // 목표 방향 계산
        Vector3 dir = (targetPoint.position - transform.position).normalized;

        // 목표 방향 바라보기
        transform.rotation = Quaternion.LookRotation(dir);

        // 앞 방향으로 전진
        transform.position += transform.forward * patrolSpeed * Time.deltaTime;

        // 목표 도착 체크
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.05f)
        {
            if (targetPoint == patrolPoint1)
                targetPoint = patrolPoint2;
            else if(targetPoint == patrolPoint2)
                targetPoint = patrolPoint3;
            else if (targetPoint == patrolPoint3)
                targetPoint = patrolPoint4;
            else
                targetPoint = patrolPoint1;



        }

    }


}
