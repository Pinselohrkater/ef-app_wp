﻿using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Animation;

namespace Eurofurence.Companion.Common.Abstractions
{
    public interface INavigationMediator
    {
        event AsyncNavigationEvent OnNavigateAsync;

        Task<bool> NavigateAsync(Type sourcePageType, bool forceNewStack = false);
        Task<bool> NavigateAsync(Type sourcePageType, object parameter, bool forceNewStack = false);
        Task<bool> NavigateAsync(Type sourcePageType, object parameter, NavigationTransitionInfo transitionInfo, bool forceNewStack = false);
    }
}