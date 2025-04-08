using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sample3.Models;
using System;
using System.Collections.ObjectModel;

namespace Sample3.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        // ObservableProperty属性で自動実装されたプロパティ（バックフィールドはnewTaskTitle）
        // 新しい書き方（partialプロパティに付与）
        // 古い書き方（フィールドに付与）
        [ObservableProperty]
        private string newTaskTitle;

        private int _nextId = 0;

        // タスク一覧（メモリ上に保存）
        public ObservableCollection<TaskModel> Tasks { get; } = new ObservableCollection<TaskModel>();

        [RelayCommand]
        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskTitle))
            {
                var task = new TaskModel
                {
                    Id = _nextId++,
                    Title = NewTaskTitle,
                    IsCompleted = false,
                    CreatedDate = DateTime.Now
                };
                Tasks.Add(task);
                NewTaskTitle = string.Empty;  // ← プロパティを使用すること！
            }
        }
        // タスク削除用コマンド
        [RelayCommand]
        private void RemoveTask(TaskModel task)
        {
            if (task != null && Tasks.Contains(task))
            {
                Tasks.Remove(task);
            }
        }

        // タスク完了状態の切替用コマンド
        [RelayCommand]
        private void ToggleTaskCompletion(TaskModel task)
        {
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
                // 必要に応じてTasksの変更通知を出す
                OnPropertyChanged(nameof(Tasks));
            }
        }
    }
}
