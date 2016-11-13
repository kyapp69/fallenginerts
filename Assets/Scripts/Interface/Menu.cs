﻿using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    public GameObject BattleGround;
    [HideInInspector] public MouseManager MouseManager = null;
    public bool ShutPanels = false;

    void Start () {
        if (this.BattleGround == null) return;

        this.MouseManager = this.BattleGround.GetComponent<MouseManager>();
    }
	
	void Update () {
	
	}

    public void HandleMenu() {
        if (this.MouseManager != null && this.ShutPanels) {
            this.MouseManager.ShutAllPanels();
        }

        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }

    public void HandlePause() {
        this.gameObject.SetActive(!this.gameObject.activeSelf);

        if (this.gameObject.activeSelf) {
             Time.timeScale = 0f;
         } else {
             Time.timeScale = 1f;
         }
    }
}