using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53;	//魔力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 魔法攻撃用の関数
	public void Magic() {
		if (this.mp >= 5) {
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}

	// 防御用の関数
	public void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//配列を宣言して順番に出力します
		int[] array = {30, 20, 50, 10, 80};
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//同じ配列を逆に出力します
		for (int j = array.Length - 1; j >= 0; j--) {
			Debug.Log (array [j]);
		}

		//Magic関数を呼び出して魔法を使います
		Boss warlock = new Boss ();
		warlock.Magic (); 

		//更に9回使って計10回魔法を使います
		for (int m = 0; m < 9; m++) {
			warlock.Magic ();
		}
		Debug.Log ("魔法を10回使いました。");

		//更にもう1回使用しMPが足りない時のメッセージが出ることを確認します
		warlock.Magic();
	}

	// Update is called once per frame
	void Update () {

	}
}