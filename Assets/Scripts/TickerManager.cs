using System;
using System.Collections.Generic;
using UnityEngine;
using Util.Attributes;

/// <summary>
/// Ticks components in a specified order
/// </summary>
public class TickerManager : MonoBehaviour {
    [Expandable] public List<Ticker> tickers = new List<Ticker>();
    [Expandable] public List<Ticker> fixedTickers = new List<Ticker>();
    
    public void Update() {
        for (int i = 0; i < tickers.Count; i++) {
            if (tickers[i].enabled) {
                tickers[i].Tick();
            }
        }
    }

    public void FixedUpdate() {
        for (int i = 0; i < fixedTickers.Count; i++) {
            if (fixedTickers[i].enabled) {
                fixedTickers[i].Tick();
            }
        }
    }

    public void OnValidate() {
        if (tickers.Count == 0) Debug.LogWarning("No tickers has been assigned");
    }
}     