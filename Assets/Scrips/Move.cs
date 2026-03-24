using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0.1f, 0, 0);// * Time.deltaTime;
        transform.position += new Vector3(0, 0.03f, 0);
    }
}
