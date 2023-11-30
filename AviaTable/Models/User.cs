using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AviaTable.Models;

public partial class User : ObservableObject
{
    [ObservableProperty] private string _firstName = string.Empty;

    [ObservableProperty] private string _lastName = string.Empty;

    [ObservableProperty] private string _patronymic = string.Empty;

    [ObservableProperty] private int _flightNumber;

    [ObservableProperty] private DateTime _departureTime;
}