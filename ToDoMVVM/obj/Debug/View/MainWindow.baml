   M S B A M L   `   `   `  ????C  ?ToDoMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoMVVMToDoMVVM  5   	   7 clr-namespace:ToDoMVVM.ModelViewToDoMVVM.ModelView  5   	   /clr-namespace:ToDoMVVM.ModelToDoMVVM.Model  5   	       ToDoMVVM.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoMVVM     5   	   /vm clr-namespace:ToDoMVVM.ModelView     5   	   *mclr-namespace:ToDoMVVM.Model     5   	     ? Title$
  MVVM??5
   	   $	??450??6   $	??800??6#    ? DataContext 5      &   ToDoMVVM.ModelView.MainViewModel  5   
   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??0.2* ?6   ?? 5      $??1* ?6   .+?5   
   ?? $??1??6   ???#256D85.??5      ?? .+?5      ?? -   5        $??listTaks??5      $??Stretch=?6Q   ??6+   ??  ?? Path$ TaskList? ?? SelectedItem 6o   ?? *SelectedTask+ ?? UpdateSourceTrigger$ PropertyChanged=???5      ?? 5      .R?5      ??  ?? Orientation$ 
Horizontal=?6)    J? Opacity 6B   ?? *OpacityTask+{?6b   ?? *	Enabled+.+?5   "   ?? $??30(?6i   $??Center=?6w   ??6*   ?? *
Priority+$ PropertyChanged=?6w   ?? 5   "   $ Vertical=?6-   .+?5   &   ?? $
??Bold"?6k   $??20(?6}   $??0q?6?   ??6.   ?? *Title+$ PropertyChanged=?6?   ?? 5   &    ?? TextWrapping$
 Wrap=?6q   $	 0.6Q?6?   $??0q?6?   ??6.   ?? *Description+$ PropertyChanged=?6?   5   #   ?? 5   "   	 d? 	IsChecked	 5    #   ?? *
Complete+??5!   #   ?? *CompleteTask+??5"   #   ?? *	IsChecked+
 ?? RelativeSource
 ?? *Self+5$      5%      5'      ?? 5(      $ 
Horizontal=?6   $??Right=?66   .+?5)      ?? $??0q?69   
?????? ??6   ?? *	AddTask+??5*      ?? 5+      ???#47B5FF ?? CornerRadius$ 10??6:   $??80??6L   ._?5,   "   ?? $??+??6,   ???#06283D$
??Bold"?6J   $??20(?6\   $??Center=?6j   5-      5/      ?? 50      $??0q?6?   
?????? ??6   ?? *
RemoveTask+??6<   ??  ?? ElementName$ listTaks??$ SelectedItem???51      ?? 52      ???#47B5FF$ 10??6:   $??80??6L   ._?53   "   ?? $??-??6,   ???#06283D$
??Bold"?6J   $??20(?6\   $??Center=?6j   54      56      ?? 57      $??0q?6<   
?????? ??6   ?? *
ClearTasks+??58      ?? 59      ???#47B5FF$ 10??6:   $??80??6L   ._?5:   "   ?? $??Clear??6,   ???#06283D$
??Bold"?6N   $??20(?6`   $??Center=?6n   5;      5=      5>      5@      5A      ?? 5B   
   ???#06283D5C      5D      5F      