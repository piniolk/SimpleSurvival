using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvName : MonoBehaviour {
    public TextMeshProUGUI textName;
    public string itemName;
    PlayerInv playerInv;
    bool isOn = false;

    void Start() {
        //playerInv = GameObject.FindWithTag("Player").GetComponent<playerInv>();
    }

    private void OnMouseEnter() {
        // check if have item
        isOn = true;
        if (itemName == null) {
            textName.text = "empty";
        } else {
            textName.text = itemName;
        }
    }

    private void OnMouseExit() {
        isOn = false;
        textName.text = "";
    }

    public void UpdateName(string newName) {
        this.itemName = newName;
        if (isOn) {
            textName.text = newName;
        }
        //Debug.Log(this.itemName);
    }

    public string GetName() {
        return this.itemName;
    }

    public void UpdateImage() {
        //var sp = Resources.Load(path) as Sprite;
        Sprite sp = Resources.Load("Assets/Resources/Sprites/Log") as Sprite;
        this.GetComponent<SpriteRenderer>().sprite = sp;
    }
}
