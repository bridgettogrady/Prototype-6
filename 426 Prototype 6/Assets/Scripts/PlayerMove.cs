using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public Vector2 spawnAttackOffset;
    public GameObject laser;
    public ChooseAttack UIScript;
    int currAttack = 0; // 0: laser, 1: fireball, 2: bomb

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currAttack = UIScript.GetCurrentAttack();

        if (Input.GetKey(KeyCode.A)) { // rotate counterclockwise
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D)) { // rotate clockwise
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        }

        // inputs for attacking
        if (Input.GetKeyDown(KeyCode.Space)) { // attacks based on criteria being met
            if (currAttack == 0) {
                Vector3 spawnPos = transform.TransformPoint(new Vector3(spawnAttackOffset.x, spawnAttackOffset.y, 0));           
                GameObject newLaser = Instantiate(laser, spawnPos, transform.rotation);
            }
        }
    }
}
