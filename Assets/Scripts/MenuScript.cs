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
	public Light flashlight; 
	//Его начальные координаты, что бы возвращаться туда
	private Vector3 DefaultPos;


	//Цвет ( RGB )
	private float red = 200.0f;
	private float green = 0.0f;
	private float blue = 0.0f;

	//Нужно ли двигаться?
	private bool MoveEnabled = false;
	//Конечная точка
	private Vector3 EndPos;

	void Start () {
		txt = GetComponent<TextMesh> (); //Пприсваиваем txt наш текст

		//Присваиваем DefaultPos координаты света
		DefaultPos = flashlight.transform.position;
		}

	void Update (){

		//Если нужно двигаться
		if (MoveEnabled) {
			
			//Если мы уже в конечной точке
			if (flashlight.transform.position == EndPos) {
				MoveEnabled = false; //Нам не нужно двигаться
			}

			flashlight.transform.position = EndPos; //Движение
		}
	}

	//Если наводим мышь на кнопку
	void OnMouseEnter()
	{
		txt.color = new Color(red,blue,green); 		//Подсветка

		EndPos = new Vector3						//Назначаем конечную точку, на кнопку
			(txt.transform.position.x,
			txt.transform.position.y,
			DefaultPos.z); 				
		
		MoveEnabled = true; 						//Двигаемся
	}

	//Если убираем мышь с кнопки
	void OnMouseExit()
	{
		txt.color = new Color(255,255,255);			//Отключаем подсветку
		EndPos = DefaultPos; 						//Назначаем конечную точку, нам нужно в начало
		MoveEnabled = true; 						//Двигаемся
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