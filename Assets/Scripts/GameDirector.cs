using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 操作 UI 物件的必要程式

public class GameDirector : MonoBehaviour {
    private GameObject _hpGauge;

    // Start is called before the first frame update
    void Start() {
        this._hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update() {
    }

    public void DecreaseHp() {
        this._hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}