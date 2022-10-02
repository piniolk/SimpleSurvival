using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvName : MonoBehaviour {
    public TextMeshProUGUI textName;
    public TextMeshProUGUI textcount;
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

    public void UpdateImage(string pathName) {
        var sp = Resources.Load(pathName, typeof(Sprite)) as Sprite;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = sp;
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(202, 197, 197, 1);
    }

    public void UpdateCount(int count) {
        textcount.text = count.ToString();
    }
}
