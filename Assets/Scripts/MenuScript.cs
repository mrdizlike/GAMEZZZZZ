//Меню
//Универсальный скрипт для кнопок
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	//В инспекторе указываем "тип" кнопки
	public bool Begin = false;
	public bool Options = false;
	public bool Exit = false;
	public bool Back = false;

	//Камеры, присваиваем в инспекторе
	public Camera MenuCam;
	public Camera SettingsCam;

	//Текст кнопки и его свойства
	private TextMesh _txt;

	//Цвет ( RGB )
	private float _red = 200.0f;
	private float _green = 0.0f;
	private float _blue = 0.0f;

	void Start () {
		_txt = GetComponent<TextMesh> (); 				//Пприсваиваем txt наш текст
	}

	//Если наводим мышь на кнопку
	void OnMouseEnter()
	{
		_txt.color = new Color(_red,_blue,_green); 		//Подсветка
	}

	//Если убираем мышь с кнопки
	void OnMouseExit()
	{
		_txt.color = new Color(255,255,255);			//Отключаем подсветку
	}

	//Нажимаем на кнопку
	void OnMouseUp()
	{
		//Если это "Старт"
		if (Begin) {
			
			SceneManager.LoadScene("Level1");			//Грузим сцену "Level1", которую указали в Build Settings проекта
		}

		//Если это "Настройки"
		if (Options) {
			
			//Переключаемся на SettingsCam
			MenuCam.enabled = false;
			SettingsCam.enabled = true;
		}

		//Если это "Назад"
		if (Back) {
			
			//Переключаемся на MenuCam
			SettingsCam.enabled = false;
			MenuCam.enabled = true;
		}

		//Если это "Выход"
		if (Exit) {
			Application.Quit ();
		}
	}
}