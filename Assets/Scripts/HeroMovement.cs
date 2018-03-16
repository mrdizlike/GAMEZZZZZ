using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 2.0f; 										//Cкорость

	private CharacterController _charController; 					//Переменная для ссылки на компонент типа CharacterController
	private Vector3 _movement = new Vector3();						//Создание вектора для будущей его передачи в Move

	void Start () {
		_charController = GetComponent<CharacterController> (); 	//Указываем объект на который будем ссылкаться
	}

	void Update () {
		
		float deltaX = Input.GetAxis ("Horizontal") * speed; 		//Изменения по оси X относительно предыдущего кадра
		float deltaZ = Input.GetAxis ("Vertical") * speed;			//Изменения по оси Z относительно предыдущего кадра
		_movement = new Vector3 (deltaX, 0, deltaZ);				//Обновление вектора _movement
		_movement = Vector3.ClampMagnitude (_movement, speed);		//Урегулирование передвижения по диагонали
	
		_movement *= Time.deltaTime;								//Независимость от кадровой частоты
		_movement = transform.TransformDirection (_movement);		//Преобразование локальных координат в глобальные
		_charController.Move (_movement);							//Движение персонажа
	}
}
