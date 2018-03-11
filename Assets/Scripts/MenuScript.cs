//Меню
//Универсальный скрипт для кнопок
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	//В инспекторе указываем "тип" кнопки
	public bool Begin = false;
	public bool Options = false;
	public bool Exit = false;

	//Текст кнопки и его свойства
	private TextMesh txt;

	//Свет, который присваиваем в инспекторе
	public Light light;
	//Его начальные координаты, что бы возвращаться туда, по Z не перемещаем
	private Vector3 defaultPos;

	//Цвет ( RGB )
	private float red = 200;
	private float green = 0;
	private float blue = 0;

	void Start () {
		txt = GetComponent<TextMesh> (); //Пприсваиваем txt наш текст

		//Присваиваем defaultPos координаты света
		defaultPos = light.transform.position;
		}

	//Если наводим мышь на кнопку
	void OnMouseEnter()
	{
		txt.color = new Color(red,blue,green); 		//Подсветка
		light.transform.position = new Vector3		//Перемещаем свет по X и Y, Z не меняем
			(txt.transform.position.x+(float)0.9,	//добавим по X, убавим по Y, чтобы было по центру
			 txt.transform.position.y-(float)0.3,	
			 defaultPos.z);  						
	}

	//Если убираем мышь с кнопки
	void OnMouseExit()
	{
		txt.color = new Color(255,255,255);			//Отключаем подсветку
		light.transform.position = defaultPos;  	//Перемещаем свет по X и Y на defaultPos
	}

	//Нажимаем на кнопку
	void OnMouseUp()
	{
		//Если это "Старт"
		if (Begin) {
			// ...
		}

		//Если это "Настройки"
		if (Options) {
			// ...
		}

		//Если это "Выход"
		if (Exit) {
			Application.Quit ();
		}
	}
}