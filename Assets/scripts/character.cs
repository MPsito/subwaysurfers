using UnityEngine;

public class character : MonoBehaviour
{
 private Rigidbody characterRigidBody;
 [SerializeField]
 private float jumpForce = 5f;
 [SerializeField]
 private float distanceTomove = 2f;
 private bool isGrounded = true;
 private void Start()
    {
        characterRigidBody = GetComponent<Rigidbody>();
    }
    public void Jump()
    {
        if (isGrounded)
        {
            characterRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }       
    }
    public void Moveleft()
    {
        transform.position += Vector3.left *distanceTomove;
    }
    public void MoveRight()
    {
          transform.position += Vector3.right *distanceTomove;
    }
    public void  OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
 
}
