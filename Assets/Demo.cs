using UnityEngine;
using EasyUI.PickerWheelUI;
using UnityEngine.UI;  // Agrega esta línea para evitar la ambigüedad
using System.IO;
using System.Xml.Serialization;

public class PuntuacionData
{
    public int Puntos;
}

public class Demo : MonoBehaviour
{
    [SerializeField] private Button uiSpinButton;
    [SerializeField] private UnityEngine.UI.Text uiSpinButtonText;  // Asegúrate de usar UnityEngine.UI.Text
    [SerializeField] private PickerWheel pickerWheel;
    [SerializeField] private UnityEngine.UI.Text uiTextNumberPoints;  // Asegúrate de usar UnityEngine.UI.Text

    private int puntos;

    private void Start()
    {
        CargarPuntuacion(); // Intenta cargar la puntuación al inicio

        uiSpinButton.onClick.AddListener(() =>
        {
            uiSpinButton.interactable = false;
            uiSpinButtonText.text = "Girando";

            // Comprueba si pickerWheel es nulo antes de usarlo
            if (pickerWheel != null)
            {
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
            }
            else
            {
                Debug.LogError("PickerWheel no está asignado. Asegúrate de asignarlo en el Inspector de Unity.");
            }
        });
    }

    private void SumarPuntos(int puntosGanados)
    {
        puntos += puntosGanados;
        GuardarPuntuacion();
        ActualizarPuntosTexto();
    }

    private void ActualizarPuntosTexto()
    {
        if (uiTextNumberPoints != null)
        {
            uiTextNumberPoints.text = puntos.ToString();
        }
    }

    private void GuardarPuntuacion()
    {
        var puntosData = new PuntuacionData { Puntos = puntos };

        var serializer = new XmlSerializer(typeof(PuntuacionData));
        using (var stream = new FileStream(GetRutaArchivo(), FileMode.Create))
        {
            serializer.Serialize(stream, puntosData);
        }
        Debug.Log("Puntuación guardada en: " + GetRutaArchivo());
    }

    private void CargarPuntuacion()
    {
        var serializer = new XmlSerializer(typeof(PuntuacionData));

        if (File.Exists(GetRutaArchivo()))
        {
            using (var stream = new FileStream(GetRutaArchivo(), FileMode.Open))
            {
                var puntosData = serializer.Deserialize(stream) as PuntuacionData;
                if (puntosData != null)
                {
                    puntos = puntosData.Puntos;
                    ActualizarPuntosTexto();
                    Debug.Log("Puntuación cargada desde: " + GetRutaArchivo());
                }
                else
                {
                    Debug.LogError("Error al deserializar los datos de puntuación.");
                }
            }
        }
        else
        {
            Debug.Log("No se encontró el archivo de puntuación en: " + GetRutaArchivo());
        }
    }

    private string GetRutaArchivo()
    {
        return Path.Combine(Application.persistentDataPath, "puntosData.xml");
    }
}
