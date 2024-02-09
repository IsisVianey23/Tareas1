using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileSystem : MonoBehaviour
{
    public static FileSystem Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        else
        { 
            Instance = this;
        }
    }

    public void CreateFile(string _name, string _extension)
    {
        //1.-Definir el path del archivo
        string path = Application.dataPath + "/" + _name + _extension;
        //2.- Revisar si el archivo en el path no existe
        if (!File.Exists(path))
        {
            //3.- Crear el contenido y almacenar la info.
            string content = "Login Date:" + System.DateTime.Now + "\n";
            //4.-Almacenar la informacion
            File.AppendAllText(path, content);
        }
        else
        {
            Debug.LogWarning("Atención: Estas tratando de crear un archivo con el mismo nombre ["
                + _name + _extension + "], verifica tu informacion");
        }
    }
    public void CreateFile(string _name, string _extension, Vector3 _vec)
    { 
        //1.-Definir el path del archivo
        string path = Application.dataPath + "/" + _name + _extension;
        //2.- Revisar si el archivo en el path no existe
        if (!File.Exists(path))
        {
            //3.- Crear el contenido y almacenar la info.
            string content = _vec.ToString() + "\n";
            Debug.Log("Se almaceno la información:" + content);
            //4.-Almacenar la informacion
            File.AppendAllText(path, content);
        }
        else 
        {
            Debug.LogWarning("Atención: Estas tratando de crear un archivo con el mismo nombre ["
                + _name + _extension +"], verifica tu informacion");
        }
    }
    private void Start()
    {
        CreateFile("26Ene2024", ".save");
    }
}
