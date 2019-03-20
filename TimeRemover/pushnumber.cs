/*
数字入力のスクリプトです
Gameobjectにはそれぞれの数字のゲームオブジェクトを入れてください
TextMeshには3dテキストに今まで入力した文字列を表示するようになっています。必要ないなら消していいです。
numbertrueには正解の数字を入れてください、ここに正解がないとエラーになります。
指のオブジェクトに入れてください
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushnumber : MonoBehaviour {
	public GameObject  one, two, three, four, five, six, seven, eight, nine,zero,kettei,torikesi;
	public TextMesh number;
	private int len=0,c=0;
	public string numbertrue;
	private string beforen,numbera=null;
	private bool ketteiT = true,torikesiT=true;
	public static int flag = 0;
	public GameObject part1;
	// Use this for initialization
	void Start () {
		len = numbertrue.Length;
	}
		

	void  OnCollisionEnter(Collision a){



		if (a.gameObject == one) {
			textchange ("1");
			beforen = "1";
		}
		if (a.gameObject == two) {
			textchange ("2");
			beforen = "2";
		}
		if (a.gameObject == three) {
			textchange ("3");
			beforen = "3";
		}
		if (a.gameObject == four) {
			textchange ("4");
			beforen = "4";
		}
		if (a.gameObject == five) {
			textchange ("5");
			beforen = "5";
		}
		if (a.gameObject == six) {
			textchange ("6");
			beforen = "6";
		}
		if (a.gameObject == seven) {
			textchange ("7");
			beforen = "7";
		}
		if (a.gameObject == eight) {
			textchange ("8");
			beforen = "8";
		}
		if (a.gameObject == nine) {
			textchange ("9");
			beforen = "9";
		}
		if (a.gameObject == zero) {
			textchange ("0");
			beforen = "0";
		}
		if (a.gameObject == kettei) {
			ketteiT = true;
			ketteia (ketteiT);
		}
		if (a.gameObject == torikesi) {
			torikesiT = true;
			torikesia (torikesiT);
		}
	}

	private void textchange(string a){
		if (c < len) {
			numbera = numbera + a;
			number.text = numbera;
			c = numbera.Length;
		}  
	}

	private void ketteia(bool T){
		if (T) {
			if (numbera == numbertrue) {
				Debug.Log (" 正解のパスワード");
				numbera = null;
				number.text = numbera;
				numbera = "Success!";
				number.text = numbera;
				flag = 1;
				part1.SetActive (true);
			} else {
				GameOver.HP--;
				Debug.Log ("間違っています");
				numbera = null;
				number.text = numbera;
				ketteiT = false;
				c = 0;
			}
		}
	}
	private void torikesia(bool T){
		if(T){
		numbera= numbera.Remove(c-1, 1);
		number.text = numbera;
		c = numbera.Length;
		torikesiT = false;
		beforen = null;
		}
	}
}



