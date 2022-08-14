using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    float speed = 5f;
    Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start() {
        this.rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, y, 0);

        if(x < 0) {
            // sprite to face left
        } else if (x == 0) {
            // sprite face forward
        } else {
            // sprite face right
        }

        transform.Translate(movement * speed * Time.deltaTime);

        if(this.gameObject.transform.position.x < -9) {
            transform.Translate(new Vector3(18, 0, 0));
        }
        if(this.gameObject.transform.position.x > 9) {
            transform.Translate(new Vector3(-18, 0, 0));
        }

        if(this.gameObject.transform.position.y < -5) {
            transform.Translate(new Vector3(0, 10, 0));
        }
        if(this.gameObject.transform.position.y > 5) {
            transform.Translate(new Vector3(0, -10, 0));
        }
    }

    public void ChangeSpeed() {
        if (this.speed == 0f) {
            this.speed = 5f;
        } else {
            this.speed = 0f;
        }
    }
}
