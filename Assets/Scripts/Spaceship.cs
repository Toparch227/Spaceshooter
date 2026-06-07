using UnityEngine;

public class Spaceship : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public GameObject laserObject;
    public GameObject cannonLeft;
    public GameObject cannonRight;

    // Update is called once per frame
    void Update()
    {
        Moevement();
        Shooting();
    }

    void Moevement()
    {
        Vector3 movement = Vector3.right * Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(movement); 

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -28, 28);
        transform.position = position;
    }

    void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserObject, cannonRight.transform.position, laserObject.transform.rotation);
            Instantiate(laserObject, cannonLeft.transform.position, laserObject.transform.rotation);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }      
    }

    private void OnDestroy()
    {
        GameManager.instance.gameOver = true;
    }
}
