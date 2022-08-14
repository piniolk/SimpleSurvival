using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InvName : MonoBehaviour {
    public TextMeshProUGUI textName;

    private void OnMouseEnter() {
        // check if have item

        // otherwise
        textName.text = "empty";
    }

    private void OnMouseExit() {
        textName.text = "";
    }
}
