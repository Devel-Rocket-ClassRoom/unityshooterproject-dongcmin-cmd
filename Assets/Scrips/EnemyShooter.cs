using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject enemyBall;
    public Transform enemySpawnPoint;
    public float enemyPower;
    //public GameObject enemyCannon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float _perTime = 2.0f; //1초마다 실행
    private float _nextTime = 0.0f; //다음번 실행할 시간
    public float timeCount = 0f;
    public float shootingTerm = 2.0f;

    void Shoot()
    {
        timeCount += Time.deltaTime;
        if(timeCount > shootingTerm)
        {
            GameObject obj = Instantiate(enemyBall, enemySpawnPoint.position, enemySpawnPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = enemySpawnPoint.up * enemyPower;
            }
            timeCount = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > _nextTime)
        {
            _nextTime = Time.time + _perTime; //다음번 실행할 시간

            GameObject obj = Instantiate(enemyBall, enemySpawnPoint.position, enemySpawnPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.linearVelocity = enemySpawnPoint.up * enemyPower;
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        //GameObject obj = Instantiate(enemyBall, enemySpawnPoint.position, enemySpawnPoint.rotation);
        //Rigidbody rb = obj.GetComponent<Rigidbody>();
        //if (rb != null)
        //{
        //    rb.linearVelocity = enemySpawnPoint.up * enemyPower;
        //}
    }
}
