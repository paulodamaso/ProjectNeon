﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardPresenter : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI type;
    [SerializeField] private Image art;

    private Card _card;
    private Action _onClick;

    public void Set(Card card, Action onClick)
    {
        _onClick = onClick;
        _card = card;
        name.text = _card.name.WithSpaceBetweenWords();
        description.text = _card.Description;
        type.text = _card.TypeDescription;
        art.sprite = _card.Art;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _onClick();
    }
}