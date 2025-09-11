using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

[RequireComponent(typeof(Rigidbody2D))]
public class SidescrollerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    public float height = 5.0f;


    // Update is called once per frame
    private void Update()
    {
        // Move the object by its current speed
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
             transform.Translate(Vector2.up * height * Time.deltaTime);
        }
    }
}

