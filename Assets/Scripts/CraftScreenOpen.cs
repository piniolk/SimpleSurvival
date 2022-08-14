using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CraftScreenOpen : MonoBehaviour {
    SpriteRenderer spriteRender;
    public TextMeshProUGUI craftText;
    public GameObject craftScreen;
    GameObject player;

    // Start is called before the first frame update
    void Start() {
        this.spriteRender = this.gameObject.GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnMouseDown() {
        craftScreen.SetActive(!craftScreen.activeSelf);
        player.GetComponent<PlayerMovement>().ChangeSpeed();
    }

    private void OnMouseEnter() {
        craftText.text = "craft";
    }

    private void OnMouseExit() {
        craftText.text = "";
    }
}
