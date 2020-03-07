﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        // 點擊左方按鈕時
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Translate(-3, 0, 0); // 往左移動 3
        }

        // 點擊右方按鈕時
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Translate(3, 0, 0); // 往右移動 3
        }
    }

    public void LButtonDown() {
        transform.Translate(-3, 0, 0);
    }

    public void RButtonDown() {
        transform.Translate(3, 0, 0);
    }
}