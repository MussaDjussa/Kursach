   M S B A M L   `   `   `  ����B  >BuckApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BuckAppBuckApp  5   	       BuckApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BuckApp     5   	     � Title$  
MainWindow��5   	   $
��1080��5	   	   $
��1920��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . .��5      �� 
�������._�5   
   � $��Center=�6   $��Center=�5      
������ $
��1700��5       � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      $
��1500 �6#   �� 5      $	��100 �6#   .+�5      �� $��1��6   
�������$	��800��69   $
��1500��6F   ._�5       � -   5          �Name$ frame_navigation��5        � NavigationUIVisibility$ Hidden=�5      5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 50Q�6'   
   ShadowDepth$
 0Q�67      Opacity$	 0.2Q�6H   5      �� 5"      -   5        $��60��5"      $��60��5#      $	��Top=�5$      $	��❌��5%      $��40(�5&      $
��Bold"�5'       J� Opacity$	 0.8Q�5(      
������ 
������ $��2q�5+      $��2��5,       � ToolTip$* $Назад к авторизации��5-      63   5.      5/      50      