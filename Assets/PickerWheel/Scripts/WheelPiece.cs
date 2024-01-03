using UnityEngine ;

namespace EasyUI.PickerWheelUI {
   [System.Serializable]
   public class WheelPiece {
      public UnityEngine.Sprite Icon ;
      public string Label ;

      [Tooltip("Cantidad de recompensa")] public int Amount;

      [Tooltip("Probabilidad en %")]
      [Range (0f, 100f)] 
      public float Chance = 100f ;

      [HideInInspector] public int Index ;
      [HideInInspector] public double _weight = 0f ;
   }
}
