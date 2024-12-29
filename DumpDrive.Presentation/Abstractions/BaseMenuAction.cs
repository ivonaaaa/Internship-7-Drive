﻿using DumpDrive.Data.Entities.Models;
using DumpDrive.Presentation.Extensions;

namespace DumpDrive.Presentation.Abstractions
{
    public class BaseMenuAction : IMenuAction
    {
        public int MenuIndex { get; set; }
        public User User { get; set; }

        public string Name { get; set; } = "NoName";
        public IList<IAction> Actions { get; set; }

        public BaseMenuAction(IList<IAction> actions)
        {
            actions.SetActionIndexes();
            Actions = actions;
        }

        public void Execute()
        {
            Open();
        }

        public virtual void Open()
        {
            Actions.PrintActionsAndOpen();
        }
    }
}