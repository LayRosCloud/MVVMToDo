using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoMVVM.Model;

namespace ToDoMVVM.ModelView
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<TaskListObject> taskList;
        private TaskListObject selectedTask;

        public ICommand AddTask { get; private set; }
        public ICommand RemoveTask { get; private set; }
        public ICommand ClearTasks { get; private set; }

        

        public TaskListObject SelectedTask
        {
            get => selectedTask;
            set {
                selectedTask = value; 
            }
        }
        public ObservableCollection<TaskListObject> TaskList
        {
            get => taskList;
            private set => taskList = value;
            
        }
        public MainViewModel()
        {
            taskList = new ObservableCollection<TaskListObject>();
            AddTask = new DelegateCommand<object>(AddTaskOnList);
            RemoveTask = new DelegateCommand<object>(RemoveTaskOnList, HasSelectedItem);
            ClearTasks = new DelegateCommand<object>(ClearTaskList);
        }

        private bool HasSelectedItem(object arg)
        {
            return (arg as TaskListObject) != null;
        }



        private void ClearTaskList(object obj)
        {
            TaskList.Clear();
        }

        
        private void RemoveTaskOnList(object obj)
        {
            taskList.Remove(obj as TaskListObject);
        }

        private void AddTaskOnList(object obj)
        {
            TaskList.Add(new TaskListObject("Введите название", "введите описание", false, 1));
        }
        private void OnPropertyChanged([CallerMemberName] string nameProperty = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
        }
    }
}
