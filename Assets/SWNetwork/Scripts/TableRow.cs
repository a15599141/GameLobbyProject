﻿using UnityEngine.UI;
using UnityEngine;

public class TableRow : MonoBehaviour // class to control row selected events (room select, player select)
{
    public delegate void SelectedHandler(string objectId);

    /// <summary>
    /// Invoked when the table row is selected.
    /// </summary>
    public event SelectedHandler OnSelected;

    public Text titleText;
    public string title;
    public string objectId;

    public void SetTitle(string title)
    {
        this.title = title;
        titleText.text= this.title;
    }

    public void SetObjectId(string objectId)
    {
        this.objectId = objectId;
    }

    public void Selected()
    {
        if (OnSelected != null)
        {
            OnSelected(objectId);
        }
    }
}
