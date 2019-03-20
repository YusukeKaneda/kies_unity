using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushnumber2 : MonoBehaviour {
	public GameObject  one2, two2, three2, four2, five2, six2, seven2, eight2, nine2,zero2,kettei2,torikesi2;
	public TextMesh number2;
	private int len2=0,c2=0;
	public string numbertrue2;
	private string beforen2,numbera2=null;
	private bool ketteiT2 = true,torikesiT2=true;
	public static int flag2 = 0;
	public GameObject part2;
	// Use this for initialization
	void Start () {
		len2 = numbertrue2.Length;
	}


	void  OnCollisionEnter(Collision b){



		if (b.gameObject == one2) {
			textchange2 ("1");
			beforen2 = "1";
		}
		if (b.gameObject == two2) {
			textchange2 ("2");
			beforen2 = "2";
		}
		if (b.gameObject == three2) {
			textchange2 ("3");
			beforen2 = "3";
		}
		if (b.gameObject == four2) {
			textchange2 ("4");
			beforen2 = "4";
		}
		if (b.gameObject == five2) {
			textchange2 ("5");
			beforen2 = "5";
		}
		if (b.gameObject == six2) {
			textchange2 ("6");
			beforen2="6";
		}
		if (b.gameObject == seven2) {
			textchange2 ("7");
			beforen2="7";
		}
		if (b.gameObject == eight2) {
			textchange2 ("8");
			beforen2="8";
		}
		if (b.gameObject == nine2) {
			textchange2 ("9");
			beforen2 = "9";
		}
		if (b.gameObject == zero2) {
			textchange2 ("0");
			beforen2="0";
		}
		if (b.gameObject == kettei2) {
			ketteiT2 = true;
			ketteia2 (ketteiT2);
		}
		if (b.gameObject == torikesi2) {
			torikesiT2 = true;
			torikesia2 (torikesiT2);
		}
	}

	private void textchange2(string b){
		if (c2 <len2) {
			numbera2 = numbera2 + b;
			number2.text = numbera2;
			c2 = numbera2.Length;
		}  
	}

	private void ketteia2(bool Y){
		if (Y) {
			if (numbera2 == numbertrue2) {
				Debug.Log (" 正解のパスワード");
				numbera2 = null;
				number2.text = numbera2;
				numbera2 = "Success!";
				number2.text = numbera2;
				flag2 = 1;
				part2.SetActive(true);

			} 
			else {
				GameOver.HP--;
				Debug.Log ("間違っています");
				numbera2 = null;
				number2.text = numbera2;
				ketteiT2 = false;
				c2 = 0;
			}
		}
	}
	private void torikesia2(bool Y){
		if(Y){
			numbera2= numbera2.Remove(c2-1, 1);
			number2.text = numbera2;
			c2 = numbera2.Length;
			torikesiT2 = false;
			beforen2 = null;
		}
	}
}