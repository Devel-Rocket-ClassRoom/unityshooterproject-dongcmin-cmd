using UnityEngine;

public class CreateEnemy : MonoBehaviour
{


    public GameObject EnemyPrefab;
    public Transform EnemyPoint;
    public int row = 5;
    //public int col = 40;
    //Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Start()
    {
        //EnemyPrefab.transform.rotation = Quaternion.Euler()
        Vector3 pos = EnemyPoint.position;
        for (int r = 0; r < row; r++)
        {

            
            pos.z = EnemyPoint.position.z + r * 10.1f;
            Instantiate(EnemyPrefab, pos, EnemyPoint.rotation);
            //pos.y = r * 1.1f;
            


            //for (int c = 0; c < col; c++)
            //{
            //    Instantiate(EnemyPrefab, pos, EnemyPoint.rotation);
            //    pos.z = EnemyPoint.position.z + c * 1.1f;
            //    pos.y = r * 1.1f;

            //}


        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
