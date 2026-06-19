using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float movementSpeed = 2f; // Variabile per la velocità di movimento della piattaforma

    // Start è chiamato una volta prima della prima esecuzione di Update dopo che il MonoBehaviour è stato creato
    void Start()
    {
        Debug.Log("START -> MovingPlatform");
        Debug.Log("START -> MovingPlatform: " + gameObject.name + " is starting to move.");
        Debug.Log("START -> MovingPlatform: movement speed is set to " + movementSpeed + " units per second.");
    }

    // Update viene chiamato una volta per frame
    void Update()
    {
        /*movementSpeed += 1.0f; // Incrementa la velocità di movimento nel tempo*/
        Debug.Log("UPDATE -> MovingPlatform");
        Debug.Log("UPDATE -> MovingPlatform: " + gameObject.name + " is moving.");
        Debug.Log("UPDATE -> MovingPlatform: movement speed is updated to " + movementSpeed + " units per second.");

        // Velocità costante per il movimento della piattaforma
        transform.position += new Vector3(movementSpeed * Time.deltaTime, 0, 0);
    }
}