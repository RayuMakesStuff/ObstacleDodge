using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        transform.Translate(x * Time.deltaTime * speed,  0, z * Time.deltaTime * speed);
    }
}