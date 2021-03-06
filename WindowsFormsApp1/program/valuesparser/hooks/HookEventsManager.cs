﻿using EventHook;
using LayoutProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1.program.valuesparser.hooks
{
    class HookEventsManager
    {
        private bool validated = false;

        public void WaitForUserAction(IUserActionCallback userAcitonCallback)
        {
            KeyboardWatcher.Start();
            MouseWatcher.Start();
            validated = false;
            MouseWatcher.OnMouseInput += (s, e) =>
            {
                if (e.Message.ToString().Equals(PathForm.GetValidationBtnName()) && !validated) 
                    Validated(userAcitonCallback);           
            };

            KeyboardWatcher.OnKeyInput += (s, e) =>
            {
                Console.WriteLine("btn name: "+ e.KeyData.Keyname);
                if (e.KeyData.Keyname.Equals(PathForm.UndoBtnName)) 
                    Undo(userAcitonCallback);
                

                if (e.KeyData.Keyname.Equals(PathForm.GetValidationBtnName()) && !validated)
                    Validated(userAcitonCallback);
            };
        }

        private void Undo(IUserActionCallback userAcitonCallback)
        {
            KeyboardWatcher.Stop();
            MouseWatcher.Stop();
            userAcitonCallback.OnBtnUndo();
            Console.WriteLine("undo!");
        }

        private void Validated(IUserActionCallback validationCallback)
        {
            validated = true;
            Console.WriteLine("validated!");
            KeyboardWatcher.Stop();
            MouseWatcher.Stop();
            validationCallback.OnBtnValidated();
        }

        public interface IUserActionCallback { 
            void OnBtnValidated();
            void OnBtnUndo();
        }
    }


}
