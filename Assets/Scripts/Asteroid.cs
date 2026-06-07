using Unity.VisualScripting;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    // Update is called once per frame

    void Start()
    {
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime);
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Laser")
        {
            GameManager.instance.score += 1;

            Destroy(gameObject);
            Destroy(other.gameObject);
        } 
    }
}
