using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analog : MonoBehaviour
{
    public GameObject pointer;
    public Rigidbody2D rbPointer;

    public Rigidbody2D rb;
    public bool isPressed = false;

    public GameObject player;
    public GameObject bullet;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        rbPointer = pointer.GetComponent<Rigidbody2D>();
        Recover();
    }

    public float maxDragDistance = 2f;

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {


            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 newMousePos;
            var titik = Vector3.Distance(mousePos, gameObject.transform.position);
            /*if (mousePos.x <= gameObject.transform.position.x) {
				rbPointer.position = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);*/
            if (mousePos.x > gameObject.transform.position.x)
            {
                newMousePos = new Vector2(gameObject.transform.position.x, mousePos.y);
                titik = Vector3.Distance(newMousePos, gameObject.transform.position);
                if (titik > maxDragDistance)
                {
                    rbPointer.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + (newMousePos - new Vector2(gameObject.transform.position.x, gameObject.transform.position.y)).normalized * maxDragDistance;
                }
                else
                    rbPointer.position = newMousePos;
            }
            else
            {
                if (titik > maxDragDistance)
                {
                    rbPointer.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y) + (mousePos - new Vector2(gameObject.transform.position.x, gameObject.transform.position.y)).normalized * maxDragDistance;
                }
                else
                    rbPointer.position = mousePos;
            }
        }
    }

    public float forceX, forceY, power = 250;
    void OnMouseDown()
    {

        isPressed = true;

    }
    void OnMouseUp()
    {
        isPressed = false;
        //rbPredictor.isKinematic = false;
        //rbPredictor.gravityScale = 1;
        StartCoroutine(Shoot());
        Recover();
        
    }

    IEnumerator Shoot()
    {
        
        GameObject obj;
        obj = Instantiate(bullet, player.transform.position, Quaternion.identity);
        CircleCollider2D colObj = obj.GetComponent<CircleCollider2D>();
        Rigidbody2D rbObj = obj.GetComponent<Rigidbody2D>();
        forceX = gameObject.transform.position.x - rbPointer.position.x;
        forceY = gameObject.transform.position.y - rbPointer.position.y;
        rbObj.AddForce(new Vector2(forceX * power, forceY * power));
        yield return new WaitForSeconds(.5f);
        colObj.enabled = true;

    }

    public void Recover() {
        rbPointer.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
    }
}
