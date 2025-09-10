using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

[RequireComponent(typeof(Rigidbody2D))]
public class SidescrollerMovement : MonoBehaviour
{

    public float speed = 5.0f;
    public float height = 5.0f;
    public bool isGrounded = false;
    public float groundDistance = 0.1f;
    public LayerMask groundLayer;

    public Color lineColor = Color.red;
    public float lineLength = 5f;

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
            if (GroundCheck() == true)
            {
                transform.Translate(Vector2.up * height * Time.deltaTime);
            }
            else
            {
                print(GroundCheck());
            }
        }
    }

    public bool GroundCheck()
    {
        return Physics.BoxCast(transform.position + Vector3.down, Vector3.one, Vector3.zero, Quaternion.identity, groundLayer);
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = lineColor;

        Vector3 start = transform.position;
        Vector3 end = start + transform.forward * lineLength;

        Gizmos.DrawLine(start, end);
    }
}

