using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float maxSpeed = 6.0f;

    GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 mousepos = new Vector2(worldPoint.x, worldPoint.y);

        Vector3 dirMouse = mousepos - transform.position;
        Vector3 dirMouseNorm = dirMouse;
        dirMouseNorm.Normalize();

        //if ()
        Debug.Log(dirMouse.magnitude);
        rb.velocity = dirMouseNorm * maxSpeed * Mathf.Clamp(mousepos.magnitude*2, 0.0f, 1f);
    }
}
