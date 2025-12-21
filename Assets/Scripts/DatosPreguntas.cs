using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Questions Data", menuName = "QuestionData")]
public class DatosPreguntas : ScriptableObject
{
    [System.Serializable]
    public struct Questions
    {
        public string questionText; //texto de la pregunta 
        public string[] replies; //array de strings que representa las posibles respuestas a las preguntas
        public int correctReplyIndex; //almacena el index de la respuesta correcta en el array
    }

    public Questions[] questions; //almacena preguntas y sus datos asociados

}
