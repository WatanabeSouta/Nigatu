using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform Camera;
    public float PlayerSpeed;
    public float RoatationSpead;

    Vector3 speed = Vector3.zero;
    Vector3 rot = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
        Camera.transform.position = transform.position;
    }

    void Move()
    {
        speed = Vector3.zero;
        rot = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {        
            rot.y = 0;
            MoveSet();
        }
        if (Input.GetKey(KeyCode.S))
        {           
            rot.y = 180;
            MoveSet();
        }
        if (Input.GetKey(KeyCode.A))
        {           
            rot.y = -90;
            MoveSet();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rot.y = 90;
            MoveSet();
        }
        
        transform.Translate(speed);
    }

    void MoveSet()
    {
        speed.z += PlayerSpeed;
        transform.eulerAngles = Camera.transform.eulerAngles + rot;
    }
    void Rotation()
    {
        var speed = Vector3.zero;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed.y += -RoatationSpead;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed.y += RoatationSpead;
        }
        Camera.transform.eulerAngles += speed;
    }
}