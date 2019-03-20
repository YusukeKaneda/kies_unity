using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class phot : MonoBehaviour {
	public RenderTexture rt;	//カメラディスプレイ
	public static int a = 0;	//シャッターカウント
	public float ct;			//残りフィルム
	public Text film;			//残りフィルム表示テキスト
	// Use this for initialization
	void Start () {
		a = 0;														//カウント初期化		
		DirectoryInfo di = Directory.CreateDirectory(@"C:\phot");	//PCのC直下に写真保存用フォルダphotを作成
	}
		
	void Update () {
		SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int)trackedObject.index);				//SteamVRのコントローラーを定義

		if (a < 20) {	//20枚まで撮影可能
			
			if (Input.GetKeyDown ("t") || device.GetPressDown (SteamVR_Controller.ButtonMask.Touchpad)) { //キーボートのtもしくはVRコントローラーのタッチパッド押し込み入力
				Take ();		
				a++;
				ct = 20 - a;
				film.GetComponent<Text> ().text = "残り枚数" + ct.ToString ("00") + "枚";　//残りフィルムを表示
			}
		} 
	}

	void Take()		//写真撮影メソッド
	{
		Texture2D tex = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
		RenderTexture.active = rt;
		tex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
		tex.Apply();
		byte[] bytes = tex.EncodeToPNG();							//保温する写真データを定義
		Object.Destroy(tex);

		{
			File.WriteAllBytes(@"C:\phot/phot" + a + ".png", bytes);	//C:/phot/ 上にphot0~19.pngを保存
		}
	}
}
