﻿using System;
using System.Collections.ObjectModel;
using Eurofurence.Companion.ViewModel.Local;
using Eurofurence.Companion.ViewModel.Local.Entity;

namespace Eurofurence.Companion.ViewModel.Abstractions
{
    public interface IDealersViewModelContext
    {
        ObservableCollection<DealerViewModel> Dealers { get; }

        event EventHandler Invalidated;
    }
}