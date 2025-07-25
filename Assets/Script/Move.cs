using UnityEngine;

public class Move : MonoBehaviour
{
    public int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.Z) && GetComponent<Transform>().position.y < 2.41f)
      {
        GetComponent<Transform>().position += Vector3.up * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.S) && GetComponent<Transform>().position.y > -0.55f)
      {
         GetComponent<Transform>().position += Vector3.down * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.Q) && GetComponent<Transform>().position.x > -2.93f)
      {
         GetComponent<Transform>().position += Vector3.left * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.D) && GetComponent<Transform>().position.x < 2.93f)
      {
         GetComponent<Transform>().position += Vector3.right * speed * Time.deltaTime;
        }
        // sauter
        if (Input.GetKey(KeyCode.Space) && GetComponent<Transform>().position.y < 2.41f)
        {
            GetComponent<Transform>().position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
