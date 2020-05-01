using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

class CollectButton :MonoBehaviour {
    public Button button;
    public Text hide;
    private void Start() {
        //this.button = GameObject.Find("Button").GetComponent<Button>();
        //this.hide = GameObject.Find("Text").GetComponent<Text>();
    }
    public void Clicked() {
        hide.GetComponent<Text>().text = "clicked!";
        SceneManager.LoadScene(1);
    }
}
