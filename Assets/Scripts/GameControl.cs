using System.Collections;
using System.Collections.Generic;
// using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    public static GameControl control; // Singleton shared in application
    public GameData data; // data loaded and store 
    public string filePath() { return Path.Combine(Application.streamingAssetsPath, "data.json"); }

    // string filePath(){
    //     return Path.Combine(Application.streamingAssetsPath, "StreamingAssets", "data.json");
    // }


    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
            LoadData();
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }




    public void SaveData()
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath(), json);
    }




    public void LoadData()
    {
        if (File.Exists(filePath()))
        {
            string file = File.ReadAllText(filePath());
            data = JsonUtility.FromJson<GameData>(file);
        }
        else
        {
            Debug.LogError("Cannot load game data");
        }

    }


}



// [System.Serializable]
// class PlayerData
// {
//     public float health;
//     public float experience;
// }

// string filePath()
// {
//     return Application.persistentDataPath + "/playerInfo.dat";
// }

// public void Save()
// {
//     BinaryFormatter bf = new BinaryFormatter();
//     FileStream file = File.Create(filePath());

//     PlayerData data = new PlayerData();
//     data.health = health;
//     data.experience = experience;

//     bf.Serialize(file, data);
//     file.Close();
// }



// public void Load()
// {

//     if (File.Exists(filePath()))
//     {
//         BinaryFormatter bf = new BinaryFormatter();
//         FileStream file = File.Open(filePath(), FileMode.Open);
//         PlayerData data = (PlayerData)bf.Deserialize(file);
//         file.Close();

//         health = data.health;
//         experience = data.experience;
//     }
// }
