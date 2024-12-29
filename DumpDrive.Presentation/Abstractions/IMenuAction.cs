﻿
namespace DumpDrive.Presentation.Abstractions
{
    public interface IMenuAction : IAction
    {
        IList<IAction> Actions { get; set; }
        int MenuIndex { get; set; }

    }
}