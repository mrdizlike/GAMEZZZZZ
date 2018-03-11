//Меню
//Универсальный скрипт для кнопок
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {

	//Глобальные переменные
	//В инспекторе указываем "тип" кнопки
	public bool Begin = false;
	public bool Options = false;
	public bool Exit = false;

	//Если наводим мышь на кнопку
	void OnMouseEnter()
	{
		//Подсветка

	}

	//Если убираем мышь с кнопки
	void OnMouseExit()
	{
		//Отключаем подсветку

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

		//Если это выход
		if (Exit) {
			Application.Quit ();
		}
	}

	void Start () {

	}
}
