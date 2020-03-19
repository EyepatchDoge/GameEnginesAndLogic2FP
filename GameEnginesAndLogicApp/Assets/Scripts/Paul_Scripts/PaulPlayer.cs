using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anime;
    public LayerMask groundDec;
    public float gDradious, flyVel;
    public Transform gDeteque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D isGrounded = Physics2D.OverlapCircle(gDeteque.position, gDradious, groundDec);
        anime.SetBool("Grounded", isGrounded);
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(myTouch.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // moves the player up when pressing the screen
                rb.velocity = Vector2.up * flyVel;
            }

        }
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(gDeteque.position, gDradious);
    }
}
