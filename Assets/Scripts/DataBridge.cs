using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using Firebase.Auth;


public class DataBridge : MonoBehaviour {

    public Text usernameInput, passwordInput;

    private Player data;

    private string DATA_URL = "https://pocket-chef-firebase.firebaseio.com/";

    private DatabaseReference databaseReference;

    void Start() {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl(DATA_URL);

        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SaveData() { 

        if(usernameInput.text.Equals("") && passwordInput.text.Equals("")) {
            print("NO DATA");
            return;
        } 

        data = new Player(usernameInput.text, passwordInput.text);

        string jsonData = JsonUtility.ToJson(data);

        databaseReference.Child("Users" + Random.Range(0, 1000000)).
            SetRawJsonValueAsync(jsonData);
            
    }

    public void LoadData() {

        FirebaseDatabase.DefaultInstance.GetReferenceFromUrl(DATA_URL).GetValueAsync()
                    .ContinueWith((task => {

                        if (task.IsCanceled) {

                        }

                        if (task.IsFaulted) { 
                            
                        }

                        if (task.IsCompleted) {

                            DataSnapshot snapshot = task.Result;

                            string playerData = snapshot.GetRawJsonValue();

                            //Player m = JsonUtility.FromJson<Player>(playerData);

                            foreach(var child in snapshot.Children) {

                                string t = child.GetRawJsonValue();

                                Player extractedData = JsonUtility.FromJson<Player>(t);

                                print("The Player is: " + extractedData.Username);
                                print("The Player's pass is: " + extractedData.Password);

                            }

                        }

        }));

    }

} // class




































