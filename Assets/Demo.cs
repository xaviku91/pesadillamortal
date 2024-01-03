using UnityEngine;
using EasyUI.PickerWheelUI;
using UnityEngine.UI;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class PlayerData
{
    [XmlElement("Puntos")] // Esto indica el nombre del elemento XML para el campo 'puntos'
   public int puntos;
}

public class Demo : MonoBehaviour
{
   [SerializeField] private Button uiSpinButton;
   [SerializeField] private Text uiSpinButtonText;
   [SerializeField] private PickerWheel pickerWheel;
   [SerializeField] private Text uiTextNumberPoints;

   private PlayerData playerData;

   private void Start()
   {
        CargarPuntuacion(); // Intenta cargar la puntuación al inicio

      uiSpinButton.onClick.AddListener(() =>
      {
            uiSpinButton.interactable = false;
            uiSpinButtonText.text = "Girando";

            pickerWheel.OnSpinEnd(wheelPiece =>
            {
               Debug.Log(
                  @" <b>Indice:</b> " + wheelPiece.Index + "           <b>Mounstruo:</b> " + wheelPiece.Label
                  + "\n <b>Cantidad:</b> " + wheelPiece.Amount + "      <b>Probabilidad:</b> " + wheelPiece.Chance + "%"
               );

               SumarPuntos(wheelPiece.Amount);

               uiSpinButton.interactable = true;
               uiSpinButtonText.text = "Girar";
            });

            pickerWheel.Spin();
      });
   }

   private void SumarPuntos(int puntos)
   {
      playerData.puntos += puntos;
      GuardarPuntuacion();
      ActualizarPuntosTexto();
   }

   private void ActualizarPuntosTexto()
   {
      if (uiTextNumberPoints != null)
      {
            uiTextNumberPoints.text = playerData.puntos.ToString();
      }
   }

   private void GuardarPuntuacion()
   {
      var serializer = new XmlSerializer(typeof(PlayerData));
      using (var stream = new FileStream(GetRutaArchivo(), FileMode.Create))
      {
            serializer.Serialize(stream, playerData);
      }
   }

   private void CargarPuntuacion()
   {
      var serializer = new XmlSerializer(typeof(PlayerData));

      try
      {
            using (var stream = new FileStream(GetRutaArchivo(), FileMode.Open))
            {
               playerData = (PlayerData)serializer.Deserialize(stream);
               ActualizarPuntosTexto();
            }
      }
      catch (FileNotFoundException)
      {
            // El archivo no existe, crea uno nuevo.
            playerData = new PlayerData();
            GuardarPuntuacion();
      }
   }

   private string GetRutaArchivo()
   {
      return Path.Combine(Application.persistentDataPath, "playerData.xml");
   }
}
