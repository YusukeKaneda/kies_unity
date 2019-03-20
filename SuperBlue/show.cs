using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class show : MonoBehaviour
{
	int i;	//カウント用変数
	public Renderer screen;		//撮影した写真表示用
	string[] url = new string[20];	//撮影した写真の絶対パスを入れる用のstring型変数
	void Start()
	{
		for (i = 0; i < phot.a; i++) {
			url [i] = "file://C:/phot/phot" + i + ".png";	//string配列に撮影した分0~19のデータの絶対パスを保存
		}
		WWW www = new WWW (url [0]);
		screen = GetComponent<Renderer> ();
		screen.material.mainTexture = www.texture;			//起動時に最初に撮影したデータを表示
		i = 1;												//初期化
	}


	void Update()
	{
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int)trackedObject.index);				//SteamVRのコントローラーを定義

		if (Input.GetMouseButtonDown (0) || device.GetPressDown (SteamVR_Controller.ButtonMask.Touchpad)) {    //マウスを左クリックもしくはVRコントローラーのタッチパッド押し込み入力
			if (i < phot.a) {
				WWW www = new WWW (url [i]);
				screen.material.mainTexture = www.texture;		//撮影したデータ撮影した分まで表示
				i++;
			} else {
				SceneManager.LoadScene ("titlle");				//表示し終わったらスタート画面にもどる
			}
		}
	}
}