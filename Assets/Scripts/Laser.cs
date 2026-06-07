using UnityEngine;

public class Laser : MonoBehaviour
{
  
    public float speed;

    void Start()
    {
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed *Time.deltaTime);
    }

    
}
