using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

class CollectButton :MonoBehaviour {
    public Button button;
    public Text hide;
    private void Start() {
        var btn = button.GetComponent<Button>();
        btn.onClick.AddListener(Onclick);
    }
    public void Onclick() {
        hide.GetComponent<Text>().text = "clicked!";
    }
}
