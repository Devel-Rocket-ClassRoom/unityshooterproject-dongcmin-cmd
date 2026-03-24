using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerDamage = 30;
    public int enemyDamage = 30;
    
    
    //public void SetPlayerAndEnemy(Player p, Enemy e)
    //{
    //    player = p;
    //    enemy = e;
    //}

    public int LifeZero(ref int health, int damage)
    {
        //Player playerdamage = GetComponent<Player>();
        health -= damage;
        return health;
    }


    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("충돌 시작: " + collision.gameObject.name);


        
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("충돌 중: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log("충돌 종료: " + collision.gameObject.name);
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("적과 충돌12");


            //만약 게임오브젝트 체력 = 0 삭제
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                //Destroy(collision.gameObject);
                //적의 체력을 감소, 총알의 값만큼
                //enemy.health = enemy.health - playerDamage;
                Debug.Log("명중" + playerDamage);
                //만약 enemy의 health가 0, 0보다 작으면 삭제
                //if (enemy.health <= 0)
                if (LifeZero(ref enemy.health, playerDamage) <= 0)
                {

                    Destroy(collision.gameObject);
                }
            }
        }
        else if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player != null)
            {
                //player.health = player.health - enemyDamage;
                Debug.Log("피격" +enemyDamage);
                //if (player.health <= 0)
                if (LifeZero(ref player.health, enemyDamage) <= 0)
                {
                    //Destroy(collision.gameObject);
                    Debug.Log("GameOver!");
                }

            }
        }

        else if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Stage")
        {
            Destroy(collision.gameObject);

        }
        Destroy(gameObject, 3f);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
