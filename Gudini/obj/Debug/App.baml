   M S B A M L   `   `   `  ����B  >BuckApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BuckAppBuckApp  5      b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          BuckApp.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:BuckApp     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5         TextBlockStandart �� 
TargetType �� Property �� Value  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border �� 
ResourceId �� TypeInTargetAssembly&   System.Windows.Controls.DataGrid �� 
TargetType ��Name	 J� SnapsToDevicePixels
 �Name J� Opacity � Points �� Stretch �� Triggers P� Property P� Value �� 
TargetName  TextBoxStyle_Standart-  'System.Windows.Input.KeyboardNavigation ��Name �� CornerRadius ��Name �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.Static.Background  Button.Static.Border  Button.MouseOver.Background 	 Button.MouseOver.Border 
 Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle_Standart ��Name��%2  &	        &	 �     &	 �     &	 �     (��     5      $" DataGridSelectAllButtonStyle��"  )&	 �    7  7  7  &	 �	    &	 H
    &	 i
    &	 �
    &		 �
    &	
 �
    &	 �
    &	     &	 5    &	 X    &	 {    7  7  7  7  7 	 7 
 7  7  7  7  �� 5	   
   " ��6*   .�5
      ��  � ��$ PT Serif)�6+   �� 5       � �� �#6018186+   �� 5       � ��$ 18(�6)   5      �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ Border��6(   #��� ��68   	 . 6y   � 5      $
 Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
 0.15Q�6o    �   ��� ��� ��� ��� $ Uniform=�6�   $��Bottom=�6�   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ Border��6;   # � ��6O    � ��5      P� 5       � �� . . �5   "   �� $ Border��69   # � ��6M    � ��5      P� 5        � {� .  . �5!   "   �� $ Arrow��6?    � y�$ 	Collapsed=�6R   5"      5$      5&      5'      �� 5(   
   " ��6.   .�5)      ��  � ��# � ��6+   �� 5*       � ��8   6,   �� 5+       � �� �#6018186+   �� 5,       � ��$ 1q�60   �� 5-       �@ TabNavigation$
 None=�6A   �� 5.       � ��$
 Left=�6;   �� 5/       �@�FocusVisualStyle 61   Z� �� 50       �@J�	AllowDrop . 6*   �� 51       �@��PanningMode$ VerticalFirst=�69   �� 52       �@��IsFlicksEnabled .  67   �� 53       � ��$ Center=�69   �� 54       � ��$ Center=�6;   �� 55       � ��$ 20(�6)   �� 56       � ��$ 40��6'   �� 57       � ��$	 220��6&   �� 58       �@J�Opacity$	 0.5Q�6(   �� 59       � �� 5:      �� 5;      " ��6&   .R�5<      �� $ border��63   $ 10��6!   #��z��6C   #��z��6m   #��z��6�   	 . ._�5=      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5>       5?      P� 5@       � {� .  . �5A   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5B      P� 5C       �@J�IsMouseOver . . �5D   "   �� $ border��6@   8   � ��6T   5E      P� 5F       �@J�IsKeyboardFocused . . �5G   "   �� $ border��6@   8   � ��6T   5H      5J      5L       5M      ]� 5N       5O      �� 5P      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5Q       �@��IsSelectionActive .  6A   ./�5S      ��  �@��SelectionBrush# � /�67   5T      5V      �� 5Y   
   .�5Z      ��  � �� 5[      �� 5\      .R�5]      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   	 . $��1��6�   5^      5`      5a      �� 5b   
   $ #f5d6d6��6;   �� 5c   
   $ #ebadad��67   �� 5d   
   $ #faebeb��6>   �� 5e   
   $ #db7070��6:   �� 5f   
   $ 	#FFC4E5F6��6<   �� 5g   
   $ 	#FF2C628B��68   �� 5h   
   $ 	#FFF4F4F4��6=   �� 5i   
   $ 	#FFADB2B5��69   �� 5j   
   $ 	#FF838383��6=   �� 5k   
   " ��6-   .�5l      ��  �@�FocusVisualStyle8   61   �� 5m       � ��8  6+   �� 5n       � ��8  6,   �� 5o       � ��# � ��6+   �� 5p       � ��$ 1q�60   �� 5q       � ��$ Center=�6;   �� 5r       � ��$ Center=�69   �� 5s       � ��$ 1q�6(   �� 5t       � ��$
 Bold"�6+   �� 5u       � ��$ Center=�6;   �� 5v       � �� �#6018186+   �� 5w       � ��$ 14(�6)   �� 5x       �@J�Opacity$	 0.8Q�6(   �� 5y       � �� 5z      �� 5{      " ��6&   .R�5|      �� $ border��6A   $	 0.7Q�6!   $ 10��6/   #��z��6Q   #��z��6{   #��z��6�   	 . ._�5}      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. #	 z	 6�   #��z��6  5~       5      P� 5�       �@��IsDefaulted . . �5�   "   �� $ border��6@   # � ��6T    � ��5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   5�      P� 5�       � �� . . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   5�      P� 5�       � {� .  . �5�   "   �� $ border��6?   8   � ��6S   �� 5�   "   $ border��6@   8   � ��6T   �� 5�   "   $ contentPresenter��6K   8 	  � ��6i   5�      5�      5�      5�      5�      5�      