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

	//Текст кнопки и его свойства
	private TextMesh txt;

	//Цвет ( RGB )
	private float red = 200.0f;
	private float green = 0.0f;
	private float blue = 0.0f;

	//Камеры, присвоим их в инспекторе
	public Camera MenuCam;
	public Camera SettingsCam;

	void Start () {
		txt = GetComponent<TextMesh> (); //Пприсваиваем txt наш текст
		}

	//Если наводим мышь на кнопку
	void OnMouseEnter()
	{
		txt.color = new Color(red,blue,green); 		//Подсветка
	}
	//Если убираем мышь с кнопки
	void OnMouseExit()
	{
		txt.color = new Color(255,255,255);			//Отключаем подсветку
	}

	//Нажимаем на кнопку
	void OnMouseUp()
	{
		//Если это "Старт"
		if (Begin) {
			
			//Грузим сцену, которую добавили в Build Settings
			SceneManager.LoadScene("Level1");
		}

		//Если это "Настройки"
		if (Options) {
			
			//Меняем камеру на SettingCam
			MenuCam.enabled = false;
			SettingsCam.enabled = true;
		}

		//Если это "Назад"
		if (Back) {

			//Меняем камеру на MenuCam
			MenuCam.enabled = true;
			SettingsCam.enabled = false;
		}

		//Если это "Выход"
		if (Exit) {
			Application.Quit ();
		}
	}
}