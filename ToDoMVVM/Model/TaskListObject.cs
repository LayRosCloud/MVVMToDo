using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ToDoMVVM.Model
{
    internal class TaskListObject : INotifyPropertyChanged
    {
        private string title;
        private string description;
        private bool enabled;
        private bool complete;
        private int priority;
        private float opacityTask;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand CompleteTask { get; set; }
        public bool Enabled
        {
            get { 
                return !Complete; 
            }
            set
            {
               enabled = !Complete;
               OnPropertyChanged();
            }
        }

        public float OpacityTask
        {
            get { return opacityTask; }
            set
            {
                opacityTask = value;
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get { return title; }
            set { 
                title = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }
        public bool Complete
        {
            get { return complete; }
            set
            {
                complete = value;
                OnPropertyChanged();
            }
        }
        public int Priority
        {
            get => priority;
            set
            {
                priority = value;
                OnPropertyChanged();
            }
        }
        
        public TaskListObject() : this("", "", false, (int)PriorityTask.Low)
        {

        }
        public TaskListObject(string title, string description, bool complete, int priority)
        {
            OpacityTask = 1;
            this.Title = title;
            this.description = description;
            this.complete = complete;
            Enabled = !complete;
            this.priority = priority;
            CompleteTask = new DelegateCommand<object>(OnCompleteTask);
            
        }

        private void OnCompleteTask(object obj)
        {
            if(Complete)
            {
                OpacityTask = 0.3f;
                return;
            }
            OpacityTask = 1f;

        }

        private void OnPropertyChanged([CallerMemberName]string nameProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
        public static TaskListObject[] GetArray()
        {
            return new[] { new TaskListObject("Задача 1", "Описание раз два три четыре пять", false, (int)PriorityTask.LowMedium) };
        }
    }
    enum PriorityTask
    {
        Low = 1,
        LowMedium,
        Medium,
        MediumHigh,
        High
    }
}
