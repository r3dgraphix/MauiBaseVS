﻿using MauiBaseVS.ViewModels;

namespace MauiBaseVS;

public partial class MainPage : ContentPage
{

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

