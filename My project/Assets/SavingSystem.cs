using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavingSystem : MonoBehaviour
{
    
    private void Start()
    {
        PlayerData playerData = new PlayerData();
        playerData.health = 50;
        playerData.playerName = "Ahmed";
        string jsonString = JsonUtility.ToJson(playerData);
        Debug.Log("Serialized JSON: " + jsonString);

        jsonString = "{\"playerName\":\"John\",\"health\":50}";
        PlayerData deserializedData = JsonUtility.FromJson<PlayerData>(jsonString);
        Debug.Log("Deserialized player name: " + deserializedData.playerName);
        Debug.Log("Deserialized score: " + deserializedData.health);
    }
}
