# Interfaz Gráfica de la Ruleta:
El juego trata de una ruleta en AR, fácil de usar en nuestro dispositivo.

<br>

## ■ Pasos a seguir:
### 1. Primero necesitamos el paquete ```DoTween```: [Descargar aquí](http://dotween.demigiant.com/download.php)
### 2. Seguidamente añadimos el paquete ```EasyUI_PickerWheel```.
### 3. Despues creamos un Canvas y añade el prefab ```PickerWheel``` a él.
```Assets/PickerWheel/Prefabs/PickerWheel.prefab```
### 4. Necesitaremos crear un script llamado ```Demo.cs```.
### 5. Agregamos el espacio de nombres ```EasyUI.PickerWheelUI```.
### 6. Codigo del script ```Demo.cs```:
```c#
using UnityEngine;
using EasyUI.PickerWheelUI;   // necesario

public class Demo : MonoBehaviour {
	// Referencia al GameObject PickerWheel (paso 3):
	[SerializeField] private PickerWheel pickerWheel;
	
	private void Start () {
		// Comienza a girar:
		pickerWheel.Spin ();
	}
}
```

<br>

## ■ Eventos de la Ruleta: OnSpinStart y OnSpinEnd:

```c#
using UnityEngine;
using EasyUI.PickerWheelUI;

public class Demo : MonoBehaviour {
	[SerializeField] private PickerWheel pickerWheel;
	
	private void Start () {
		pickerWheel.OnSpinStart (() =>  {
			Debug.Log ("Inicio del giro...");
		});

		pickerWheel.OnSpinEnd (wheelPiece => {
			Debug.Log ("Fin del giro:");
			Debug.Log ("Índice   : " + wheelPiece.Index);
			Debug.Log ("Probabilidad  : " + wheelPiece.Chance);
			Debug.Log ("Etiqueta   : " + wheelPiece.Label);
			Debug.Log ("Cantidad  : " + wheelPiece.Amount);
		});

		pickerWheel.Spin ();
	}
 }
```

<br><br>
<br>

