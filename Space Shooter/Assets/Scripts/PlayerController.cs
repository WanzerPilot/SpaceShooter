using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;
    float xInput, yInput;
    [SerializeField] Sprite[] spriteArray;
    [SerializeField] GameObject missilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        if (xInput < 0) { spriteRenderer.sprite = spriteArray[1]; }
        else if (xInput > 0) { spriteRenderer.sprite = spriteArray[2]; }
        else { spriteRenderer.sprite = spriteArray[0]; }

        if (Input.GetAxis("Fire1") > 0) Shoot();

    }
    // Update is called once per frame
    void FixedUpdate()
    {//calcule position horizontale

        Vector3 position = transform.position;
        position.x = position.x + (xInput * speed * Time.deltaTime);
        //calcule position verticale

        position.y = position.y + (yInput * speed * Time.deltaTime);
        //applique la nouvelle position
        rb.MovePosition(position);
    }

    void Shoot()
    {
        GameObject missileInstance = Instantiate(missilePrefab);
        missileInstance.transform.position = transform.position;
    }

}
