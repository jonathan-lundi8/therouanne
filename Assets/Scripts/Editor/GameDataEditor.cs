using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class GameDataEditor : EditorWindow
{
    public GameData data;
    public string filePath() { return Path.Combine(Application.streamingAssetsPath, "data.json"); }


    [MenuItem("Window/Game Data Editor")]
    static void Init()
    {
        GameDataEditor window = (GameDataEditor)EditorWindow.GetWindow(typeof(GameDataEditor));
        window.Show();
    }

    void OnGUI()
    {
        if (data != null)
        {
            SerializedObject serializedObject = new SerializedObject(this);
            SerializedProperty serializedProperty = serializedObject.FindProperty("data");

            EditorGUILayout.PropertyField(serializedProperty, true);
            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("Save")) { SaveData(); }
        }

        if (GUILayout.Button("Load")) { LoadData(); }

    }

    void LoadData()
    {
        if (File.Exists(filePath()))
        {
            string jsonData = File.ReadAllText(filePath());
            data = JsonUtility.FromJson<GameData>(jsonData);
            // GameControl.control.data = data;
        }
        else
        {
            data = new GameData();
        }
        // GameControl.control.LoadData();
        // data = GameControl.control.data;
    }



    void SaveData()
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath(), json);
        // GameControl.control.SaveData();

    }
}


