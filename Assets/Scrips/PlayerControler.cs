using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public int playerHealth = 100;
    [SerializeField] private float jumpPower = 0.15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float rotDir = 0;
        //만약에 w키를 누르면 포탑이 올라감
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(0, 0, 0.1f);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);

            //rotDir = 1;
            //Debug.Log("A" + transform.position);

        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(0, 0, -0.1f);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.1f);


            //rotDir = -1;
            //Debug.Log("D" + transform.position);
        }
        //transform.localRotation *= Quaternion.Euler(0f, 0f, rotDir * 1.0f);

        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.Translate(0.1f, 0, 0);
            //transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);

            //rotDir = 1;
            //Debug.Log("W" + transform.position);

        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.Translate(-0.1f, 0, 0);

            //transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);


            //rotDir = -1;
            //Debug.Log("S" + transform.position);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {

            Rigidbody rb = GetComponent<Rigidbody>();
            if(rb)
            {
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
            //transform.Translate(0, 0.05f, 0);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.1f);
            //위 두개 차이?? 뭐가 나은지



            //rotDir = 1;
            //Debug.Log("Space" + transform.position);

        }

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        //Debug.Log("Mouse X:" + h + ", Mouse Y:" + v);

        //transform.localRotation *= Quaternion.Euler(0f, 0f, 0f);
        transform.Rotate(Vector3.up * h);
    }
}
