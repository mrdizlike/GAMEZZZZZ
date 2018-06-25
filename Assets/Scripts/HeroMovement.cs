using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour {

	public float speed = 2.0f; 										//Cкорость
    public float StartAnim = 0f;
    float deltaX = 0f;
    float deltaZ = 0f;

    private CharacterController _charController; 					//Переменная для ссылки на компонент типа CharacterController
	private Vector3 _movement = new Vector3();						//Создание вектора для будущей его передачи в Move

	void Start () {
		_charController = GetComponent<CharacterController> (); 	//Указываем объект на который будем ссылаться
    }

	void Update () {
		
		 deltaX = Input.GetAxis ("Horizontal") * speed; 		    //Изменения по оси X относительно предыдущего кадра
		 deltaZ = Input.GetAxis ("Vertical") * speed;			    //Изменения по оси Z относительно предыдущего кадра
        _movement = new Vector3 (deltaX, 0, deltaZ);				//Обновление вектора _movement
		_movement = Vector3.ClampMagnitude (_movement, speed);		//Урегулирование передвижения по диагонали
	
		_movement *= Time.deltaTime;								//Независимость от кадровой частоты
		_movement = transform.TransformDirection (_movement);		//Преобразование локальных координат в глобальные
		_charController.Move (_movement);                           //Движение персонажа
    }
    public enum direction : int
    {
        front = 1,
        back,
        left,
        right,
        DiagLeftFront,
        DiagLeftBack,
        DiagRightFront,
        DiagRightBack
    };
    public int returnAnim()
    {
        if (deltaZ < -StartAnim && deltaX <-StartAnim) { Debug.Log("diagfrontleft"); return (int)direction.DiagLeftFront;  }
        if (deltaZ < -StartAnim && deltaX > StartAnim) { Debug.Log("diagrightfront"); return (int)direction.DiagRightFront; }
        if (deltaZ > StartAnim && deltaX > StartAnim) { Debug.Log("diagRightBack"); return (int)direction.DiagRightBack;  }
        if (deltaZ > StartAnim && deltaX < -StartAnim) { Debug.Log("DiagLeftBack"); return (int)direction.DiagLeftBack;   }
        if (deltaZ < -StartAnim) { Debug.Log("front"); return (int)direction.front; }
        if (deltaZ > StartAnim) { Debug.Log("back"); return (int)direction.back;  }
        if (deltaX < -StartAnim) { Debug.Log("left"); return (int)direction.left;  }
        if (deltaX > StartAnim) { Debug.Log("right"); return (int)direction.right; }
        Debug.Log("IDLE");
        return 0;
    }
    
}
