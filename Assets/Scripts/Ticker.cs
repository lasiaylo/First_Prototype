using System;
using UnityEngine;

public abstract class Ticker: MonoBehaviour {
    public abstract void Tick();

    /// <summary>
    /// Left in so enable checkbox appears in Inspector
    /// </summary>
    public void OnEnable() { }
}
