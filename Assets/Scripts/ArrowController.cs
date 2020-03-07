using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {
    private GameObject _player;

    // Start is called before the first frame update
    void Start() {
        this._player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update() {
        // 每個影格等速往下移動
        transform.Translate(0, -0.1f, 0);

        // 當箭頭超出遊戲畫面時就捨棄物件
        if (transform.position.y < -5.0f) {
            Destroy(gameObject);
        }

        // 衝突判定
        Vector2 p1 = transform.position; // 箭頭的圓心座標
        Vector2 p2 = this._player.transform.position; // 遊戲角色的圓心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; // 箭頭的圓半徑
        float r2 = 1.0f; // 遊戲角色的圓半徑

        if (d < r1 + r2) {
            // 發生衝突時就捨棄箭頭
            Destroy(gameObject);
        }
    }
}