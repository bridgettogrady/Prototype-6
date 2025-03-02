using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public Vector2 spawnAttackOffset;
    public GameObject laser;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) { // rotate counterclockwise
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) { // rotate clockwise
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        // inputs for attacking
        if (Input.GetKeyDown(KeyCode.Space)) { // for now, shoot laser
            Vector3 spawnPos = transform.TransformPoint(new Vector3(spawnAttackOffset.x, spawnAttackOffset.y, 0));           
            Instantiate(laser, spawnPos, transform.rotation);
        }
    }
}
