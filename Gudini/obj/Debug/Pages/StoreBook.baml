   M S B A M L   `   `   `  ����B  >BuckApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BuckApp.PagesBuckApp.Pages  5          BuckApp.Pages.StoreBook   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:BuckApp.Pages     5      $	��800��5      $
��1500��5	        N� Title$  	StoreBook��5
       � 	Resources 5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle_Search �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  TabItem.Selected.Background  TabItem.Selected.Border  TabControlStyle1 �Name   TabNavigation � ColumnDefinitions ��Name � RowDefinitions ��Name ��Name K� IsItemsHost   TabIndex K� ZIndex   DirectionalNavigation ��Name  FocusVisual �� StrokeDashArray  TabItem.Static.Background  �� EndPoint! �� 
StartPoint" � Color# � Offset 	 TabItem.Static.Border  
 TabItem.MouseOver.Background  TabItem.MouseOver.Border   TabItem.Selected.Background1  TabItem.Selected.Border1  TabItem.Disabled.Background  TabItem.Disabled.Border  TabItemStyle1$ J� Opacity% �� RelativeSource& �� AncestorType' ^� 
Conditions( �� Binding  FocusVisual1  TabItem.Static.Background1  TabItem.Static.Border1 ! TabItem.MouseOver.Background1  TabItem.MouseOver.Border1   TabItem.Disabled.Background1  TabItem.Disabled.Border1  TabItemStyle2  ListBox.Static.Background  ListBox.Static.Border  ListBox.Disabled.Background  ListBox.Disabled.Border  ListViewStyle1) �� Padding��%�[  &	        &	 #     &	 F     &	 i     7  7  &	 k    &	 �    &	 �    7  7  &	 �    &	 C    &		 �    &	
 �    &	 �    &	 �    &	 �    &	 �    &	     &	 9    7  7  7 	 7 
 7  7 
 7  7 
 7  7 
 7  7  7  7  7  7  7  7  7  &	 �3    &	 ?4    &	 �4    &	 �4    &	 �5    &	 �5    &	 �5    &	 �5    7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  7  &	 9U    &	 \U    &	 U    &	 �U    &	 �U    7  7  7  7  �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6,   .�5      ��  � ��# � ��6+   �� 5       � ��
 �   �6,   �� 5       � ��# � ��6+   �� 5       � ��$	 1.5q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � ��$ PT Serif)�6+   �� 5       � ��$ 32(�6)   �� 5       � ��$ Center=�69   �� 5       � ��$ Center=�6;   �� 5       �@J�Opacity$	 0.5Q�6(   �� 5       � ��$ Regular"�6+   �� 5        � �� 5!      �� 5"      " ��6&   .R�5#      �� $ border��63   $ 20��6!   #��z��6C   #��z��6m   #��z��6�   	 . ._�5$      �� $
 PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5%       5&      P� 5'       � {� .  . �5(   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5)      P� 5*       �@J�IsMouseOver . . �5+   "   �� $ border��6@   8    � ��6T   5,      P� 5-       �@J�IsKeyboardFocused . . �5.   "   �� $ border��6@   8   � ��6T   5/      51      53       54      ]� 55       56      �� 57      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 58       �@��IsSelectionActive .  6A   ./�5:      ��  �@��SelectionBrush# � /�67   5;      5=      �� 5>   
   $ #FFFFFF��6>   �� 5?   
   $ #ACACAC��6:   �� 5@   
   " ��6)   .�5A      ��  � ��$ 2q�6(   �� 5B       � ��$ Center=�6;   �� 5C       � ��$ Center=�69   �� 5D       � ��8   6+   �� 5E       � ��8  6,   �� 5F       � ��$ 0q�60   �� 5G       � ��# � ��6+   �� 5H       � �� 5I      �� 5J      " ��6&   .R�5K      � $ templateRoot��6   }�. 	 . $ Local=�6d    5L      �� 5M   "   $ ColumnDefinition0��63   �� 5N   "   $ ColumnDefinition1��63   $��0 �6N    5P      �� 5Q   "   $ RowDefinition0��60   $
��Auto �6H   �� 5R   "   $ RowDefinition1��60   $��* �6H   .+�5T      �� $ headerPanel��6'   
������ $��0��6U    . $��2,2,2,0q�6x   $��0��6�   $ 1��6�   $ 1��6�   �� 5U      $ contentPanel��6%   #��z��6;   #��z��6e   #��z��6�   $��0��6�   $ 	Contained=�6�   $��1��6
  $ 2��6  $ Local=�67  ._�5V   "   �� $ PART_SelectedContentHost��63   $��SelectedContent��6U   #��z��6u   #	 z	 6�   5W      5X       5Y      P� 5Z       �@��TabStripPlacement$ Bottom=�6C   . �5[   "   �� $ headerPanel��6=    � ��$ 1��6V   �� 5\   "   $ contentPanel��6=    � ��$ 0��6W   �� 5]   "   $ RowDefinition0��6;    � ��$ * �6W   �� 5^   "   $ RowDefinition1��6;    � ��$
 Auto �6W   �� 5_   "   $ headerPanel��6;    � ��$ 2,0,2,2q�6T   5`      P� 5a       �@��TabStripPlacement$
 Left=�6C   . �5b   "   �� $ headerPanel��6=    � ��$ 0��6V   �� 5c   "   $ contentPanel��6=    � ��$ 0��6W   �� 5d   "   $ headerPanel��6@    � ��$ 0��6Y   �� 5e   "   $ contentPanel��6@    � ��$ 1��6Z   �� 5f   "   $ ColumnDefinition0��6:    � ��$
 Auto �6Y   �� 5g   "   $ ColumnDefinition1��6:    � ��$ * �6Y   �� 5h   "   $ RowDefinition0��6;    � ��$ * �6W   �� 5i   "   $ RowDefinition1��6;    � ��$ 0 �6W   �� 5j   "   $ headerPanel��6;    � ��$ 2,2,0,2q�6T   5k      P� 5l       �@��TabStripPlacement$ Right=�6C   . �5m   "   �� $ headerPanel��6=    � ��$ 0��6V   �� 5n   "   $ contentPanel��6=    � ��$ 0��6W   �� 5o   "   $ headerPanel��6@    � ��$ 1��6Y   �� 5p   "   $ contentPanel��6@    � ��$ 0��6Z   �� 5q   "   $ ColumnDefinition0��6:    � ��$ * �6Y   �� 5r   "   $ ColumnDefinition1��6:    � ��$
 Auto �6Y   �� 5s   "   $ RowDefinition0��6;    � ��$ * �6W   �� 5t   "   $ RowDefinition1��6;    � ��$ 0 �6W   �� 5u   "   $ headerPanel��6;    � ��$ 0,2,2,2q�6T   5v      P� 5w       � {� .  . �5x   "   �� $ templateRoot��6K   # � ��6e    � ��5y      5{      5}      5~      �� 5   
   .�5�      ��  � �� 5�      �� 5�      .R�5�      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   	 . $��1��6�   5�      5�      5�      �� 5�   
   $	  0,1&�6@   $	! 0,0&�6O   .��5�      � $" #F0F0F0��6   $	# 0.0Q�6+   � 5�      $" #E5E5E5��6   $	# 1.0Q�6+   5�      �� 5�   
   $ #ACACAC��68   �� 5�   
   $	  0,1&�6C   $	! 0,0&�6R   .��5�      � $" #ECF4FC��6   $	# 0.0Q�6+   � 5�      $" #DCECFC��6   $	# 1.0Q�6+   5�      �� 5�   
   $ #7EB4EA��6;   �� 5�   
   $ #FFFFFF��6?   �� 5�   
   $ #ACACAC��6;   �� 5�   
   $ #F0F0F0��6>   �� 5�   
   $ #D9D9D9��6:   �� 5�   
   " ��6&   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��
 �   �6+   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��$ 0q�6'   �� 5�       � ��$ 6,2,6,2q�6(   �� 5�       � ��$ Stretch=�6;   �� 5�       � ��$ Stretch=�69   �� 5�       � ��$ 0q�60   �� 5�       � ��$ PT Serif)�6+   �� 5�       � ��$ 28(�6)   �� 5�       �@J�Opacity$	 0.7Q�6(   �� 5�       � �� �#6018186+   �� 5�       � ��$	 200��6&   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � $ templateRoot��6   	 . .+�5�      �� $ 
mainBorder��6%   
������ 
������ $��0q�6l   $��0q�6�   ._�5�   "   �� $ innerBorder��6*   
������ 
������ $��0q�6r   $��0q�6�   $$ 0Q�6�   5�      �� 5�      $ contentPresenter��6/   $��Header��6I   |�.  #��z��6�   ��. #	 z	 6/  ��6r   �� *HorizontalContentAlignment+% �� "& ����6k  �� *VerticalContentAlignment+% �� "& ��5�       5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�   "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�   "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5�   "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5�   "   �� $ 
mainBorder��6?   8 	  � ��6W   �� 5�   "   $ 
mainBorder��6@   8 
  � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�   "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�   "   $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�   "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�   "   $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5�   "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�   "   $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5�   "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5�   "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5�      ^� 5�      ' 5�   "   �� 5�   &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�   &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5�   "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�   "   $ 
mainBorder��6?   8   � ��6W   �� 5�   "   $ 
mainBorder��6@   8   � ��6X   �� 5   "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5  "   �� $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5	  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5
     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5  "   ��  �@K�ZIndex$ 1��6A   �� 5  "    � ��$ 
-2,-2,0,-2q�6;   �� 5  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5  "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5  "   �� $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5     ^� 5     ' 5  "   �� 5   &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5!  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5#  "   ��  �@K�ZIndex$ 1��6A   �� 5$  "    � ��$ 
-2,0,-2,-2q�6;   �� 5%  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5&  "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5'  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5(     ^� 5)     ' 5*  "   �� 5+  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5,  &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5.  "   �� $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5/  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   50     ^� 51     ' 52  "   �� 53  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 54  &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�56  "   ��  �@K�ZIndex$ 1��6A   �� 57  "    � ��$ 
0,-2,-2,-2q�6;   �� 58  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 59  "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5:  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5;     ^� 5<     ' 5=  "   �� 5>  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5?  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5A  "   �� $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5B  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5C     ^� 5D     ' 5E  "   �� 5F  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5G  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5I  "   ��  �@K�ZIndex$ 1��6A   �� 5J  "    � ��$ 
-2,-2,-2,0q�6;   �� 5K  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5L  "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5M  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5N     5P     5R     5S     �� 5T  
   .�5U     ��  � �� 5V     �� 5W     .R�5X     �� $��2q�6$   $	 1 2R�6/   #��� ��6E   	 . $��1��6�   5Y     5[     5\     �� 5]  
   $	  0,1&�6A   $	! 0,0&�6P   .��5^     � $" #F0F0F0��6   $	# 0.0Q�6+   � 5_     $" #E5E5E5��6   $	# 1.0Q�6+   5`     �� 5a  
   $ #ACACAC��69   �� 5b  
   $	  0,1&�6D   $	! 0,0&�6S   .��5c     � $" #ECF4FC��6   $	# 0.0Q�6+   � 5d     $" #DCECFC��6   $	# 1.0Q�6+   5e     �� 5f  
   $ #7EB4EA��6<   �� 5g  
   $ #F0F0F0��6?   �� 5h  
   $ #D9D9D9��6;   �� 5i  
   " ��6&   .�5j     ��  �@�FocusVisualStyle8   61   �� 5k      � ��
 �   �6+   �� 5l      � ��8  6+   �� 5m      � ��8  6,   �� 5n      � ��$ 0q�6'   �� 5o      � ��$ 6,2,6,2q�6(   �� 5p      � ��$ Stretch=�6;   �� 5q      � ��$ Stretch=�69   �� 5r      � ��$ 0q�60   �� 5s      � ��$ PT Serif)�6+   �� 5t      � ��$ 28(�6)   �� 5u      �@J�Opacity$	 0.7Q�6(   �� 5v      � �� �#6018186+   �� 5w      � ��$	 200��6&   �� 5x      � �� 5y     �� 5z     " ��6&   .R�5{     � $ templateRoot��6   	 . .+�5}     �� $ 
mainBorder��6%   ���#f5d6d6
������ $��0q�6h   ._�5~  "   �� $ innerBorder��6)   
������ 
������ $��0q�6q   $$ 0Q�6�   5     �� 5�     $ contentPresenter��6/   $��Header��6I   |�.  #��z��6�   ��. #	 z	 6/  ��6r   �� *HorizontalContentAlignment+% �� "& ����6k  �� *VerticalContentAlignment+% �� "& ��5�      5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�  "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�  "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5�  "   �� $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *IsMouseOver+% �� *Self+ true6v   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5�  "   �� $ 
mainBorder��6?   8 	  � ��6W   �� 5�  "   $ 
mainBorder��6@   8 
  � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�  "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�  "   $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�  "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�  "   $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5�  "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�  "   $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *	IsEnabled+% �� *Self+	 false6t   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5�  "   �� $ contentPresenter��6<    �@J�Opacity$
 0.56Q�6Z   �� 5�  "   $ 
mainBorder��6?   8   � ��6W   �� 5�  "   $ 
mainBorder��6@   8   � ��6X   �� 5�  "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�  "   �� $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& �� Left6�   .0�5�  "   ��  �@K�ZIndex$ 1��6A   �� 5�  "    � ��$ 
-2,-2,0,-2q�6;   �� 5�  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5�  "   $ innerBorder��6D    � ��$ 1,1,0,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,1,0,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�  "   �� $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5�  &   ( 60   �� *TabStripPlacement+% �� "& ��
 Bottom6�   .0�5�  "   ��  �@K�ZIndex$ 1��6A   �� 5�  "    � ��$ 
-2,0,-2,-2q�6;   �� 5�  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5�  "   $ innerBorder��6D    � ��$ 1,0,1,1q�6]   �� 5�  "   $ 
mainBorder��6D    � ��$ 1,0,1,1q�6\   5�     ^� 5�     ' 5�  "   �� 5�  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5   &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5  "   �� $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& ��	 Right6�   .0�5
  "   ��  �@K�ZIndex$ 1��6A   �� 5  "    � ��$ 
0,-2,-2,-2q�6;   �� 5  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5  "   $ innerBorder��6D    � ��$ 0,1,1,1q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 0,1,1,1q�6\   5     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+	 false6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5  "   �� $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5     ^� 5     ' 5  "   �� 5  &   ( 60   �� *
IsSelected+% �� *Self+ true6u   �� 5  &   ( 60   �� *TabStripPlacement+% �� "& �� Top6�   .0�5  "   ��  �@K�ZIndex$ 1��6A   �� 5  "    � ��$ 
-2,-2,-2,0q�6;   �� 5  "   $ innerBorder��6<    �@J�Opacity$ 1Q�6U   �� 5   "   $ innerBorder��6D    � ��$ 1,1,1,0q�6]   �� 5!  "   $ 
mainBorder��6D    � ��$ 1,1,1,0q�6\   5"     5$     5&     5'     �� 5(  
   $ 	#FFFFFFFF��6<   �� 5)  
   $ 	#FFABADB3��68   �� 5*  
   $ 	#FFFFFFFF��6>   �� 5+  
   $ 	#FFD9D9D9��6:   �� 5,  
   " ��6'   .�5-     ��  � ��8   6+   �� 5.      � ��8  6,   �� 5/      � ��$ 1q�60   �� 50      � ��# � ��6+   �� 51      � ��$
 Auto=�6K   �� 52      � ��$
 Auto=�6I   �� 53      � �� . 6>   �� 54      �@��PanningMode$
 Both=�69   �� 55      �@��IsFlicksEnabled .  67   �� 56      � ��$ Center=�69   �� 57      � �� 58     �� 59     " ��6&   .R�5:     �� $ Bd��6!   #��z��6-   #��z��6W   #��z��6�   $) 1q�6�   	 . ._�5;     �� |�.  #��z��6=   .��5<  "   �� #	 z	 61   5=     5>      5?     P� 5@      � {� .  . �5A  "   �� $ Bd��6?   8   � ��6O   �� 5B  "   $ Bd��6@   8   � ��6P   5C     ]� 5D      5E  "   �� 5F  &    �@��
IsGrouping . 6F   �� 5G  &   " �@%�IsVirtualizingWhenGrouping .  6h   ./�5I  "   ��  � �� .  6R   5J     5L     5N     5O     5P     .��5R     � 
������� 5S  
   �� 5T     $	��120 �6   �� 5U     �� 5V     $	��120 �6    5Y  
   �� 5Z     $	��130 �6   �� 5[     $��60 �6   �� 5\     .+�5`  
   �� $��2��6   $��1��5a       TextBlockStandart#��[ 5b     $+��%Книжные бестселлеры��5c     $
��Bold"�5d     
���   �$��38(�5f     $��Bottom=�5g     �� 5k  
   $��1��6   $��3��5l     
�������$	$ 0.4Q�5n     �� 5p  
   $��0��6   $��1��5q     ]� 5s  
   $��1��6   .+�5t     �� $��МирКниг:��6   #��[ 5u     $
��Bold"�5v     $��36(�5w     $��Center=�5x     �� 5y     -   5        * ��Name$* 	filterBox��5|     #���  5y     $��30q�5z     ��5{     �� *
FilterText++ �� UpdateSourceTrigger$+ PropertyChanged=�.��5|  )   5~     5     �� 5�  
   #���  6   $��2��6@   $��1��6Q   $��1��6^   .@�5�     �� #���  6   $��Главная��6>   $��58��5�     
������ .��5�     �  5�     �� 5�     $��80 �6(   �� 5�     .+�5�     �� $��0��6    $+��%Книжные бестселлеры��5�      $
��Bold"�5�      $��Bottom=�5�      $��40(�5�      �� 5�     -   5        #���  5�     $��1��6H   $��Disabled=�5�     $��0q�5�     ��5�  U   �� *Book+, �� SelectedItem, 5�     �� *SelectedItem+��5�     �� 5�     .R�5�  "   � 5�     ��5�     �� 5�     .R�5�  "   �� $	��550��6)   $	��330��5�  )   $��1q�5�  )   
�������
������ $��20q�5�  )   ._�5�  &   � $��10q�6+    5�  *   �� 5�  .   $��30 �6<   �� 5�  .   .+�5�  *   � $��0��6/    5�  .   �� 5�  2   $	��275 �6C   �� 5�  2   $��30 �6C   .+�5�  .   �� $��18(�5�  8   $	$ 0.5Q�5�  8   $��0��5�  8   $	��260��5�  8   ��5�  8   �� *
Genre.Name+- � ToolTip- 5�  8   �� *
Genre.Name+�� 5�  .   $��1��67   .@�5�  2   �� .��6?   Отложить6I   �� 5�  2   .��6?   Читать фрагмент6P   5�  /   5�  +   �� 5�  *   $	��400��5�  0   $	��320��5�  0   $
��Fill=�5�  0   $��1��5�  0   $	��Top=�5�  0   $��0,10,0,0q�5�  0   ��5�  0   �� *Cover+5�  0   �� 5�  *   $ 1��61   ���#1a0000$	��180��5�  1   $��Bottom=�5�  1   $��1��5�  1   $	$ 0.8Q�5�  1   ._�5�  .   � $��15q�63    5�  2   �� 5�  6   �� 5�  6   $��30 �6D   .+�5�  2   �� $��0��6=   .+�5�  6   �� #��[ 5�  <   $��18(�5�  <   
�������$
��Wrap=�5�  <   $
��Bold"�5�  <   . �� TextAlignment$
. Left=�5�  <   ��5�  @   �� *Name+5�  <   �� 5�  6   / �� Orientation$/ 
Horizontal=�6A   $��0,5,5,5q�5�  A   $	$ 0.6Q�5�  A   .+�5�  :   �� 
�������$��16(�5�  @   $. Center=�5�  @   ��5�  D   �� *Author.LName+5�  @   �� 5�  :   
�������$��16(�5�  @   $. Center=�5�  @   $��5,0,5,0q�5�  @   ��5�  D   �� *Author.FName+5�  @   �� 5   :   
�������$��16(�5  @   $. Center=�5  @   ��5   D   �� *Author.MName+5  @   5  7   5  3   � 5  2   $��1��67    5	  6   �� 5
  :   �� 5  :   .+�5  6   �� $��0��6A   $/ 
Horizontal=�5  A   .+�5  :   �� $ 5��6A   
������ $��1q�5  A   
���  ��._�5  ?   �� 0 ��Name$0 price��5  D   -   5        $��5q�5  D   $��16(�5  D   
�������$��Center=�5  D   5  ;   �� 5  :   $0 discount��5!  @   -   5        
�������$��16(�5   @   $��Center=�5#  @   5&  7   �� 5*  6   $��1��6=   $��Right=�5+  9   $��80��5,  9   
���  ��
�������$��Купить��5/  9   $��16(�50  9   
������ $��0q�52  9   53  3   56  /   59  +   5:  '   5;  #   5=     5?     5A     5C     �� 5D     #���  6   $��Новинки��6>   $��58��5E     
������ .��5G     � 
���  ��6   5H     �� 5I     #���  6   $��Популярное��6>   $��58��5J     
������ .��5L     � 
����  �6   5N     �� 5O     #���  6   $��Что почитать?��6>   $��58��5P     
������ $	��250��5R     .��5S     � 
��� ���6   5T     �� 5U     #���  6   $��Читать��6>   $��58��5V     $	��220��5W     $
��Bold"�5X     .��5Y     �� -   5        #���  5Y     $��1��6D   $��Disabled=�5Z     $��0q�5[     ��5Y  Q   �� *
BookUser+, 5\     �� *SelectedItem_UserBook+��5^     �� 5_     .R�5`     � 5a     ��5c     �� 5d     .R�5f     �� $	��485��6%   $	��332��62   ���#D4D5C6$ 30��6S   $��30q�6e   ._�5g  "   �� .+�5h  &   �� $	��400��5i  0   $	��332��5j  0   $
��Fill=�5k  0   ��5h  ,   �� *
Book.Cover+5k  0   �� 5l  &   #��[ 5m  4   $��16(�5n  4   $	$ 0.7Q�5o  4   $��Center=�5p  4   $��0,10,0,5q�5q  4   ��5l  0   �� *	Book.Name+5q  4   �� 5r  &   $	��285��6-   
���   �$��Center=�6L   $��1��6i   $	$ 0.3Q�6t   �� 5s  &   #��[ 5t  4   $��16(�5u  4   $	$ 0.7Q�5v  4   $��Center=�5w  4   $��0,5,0,0q�5x  4   ��5s  0   �� *Book.Author.LName+5x  4   5y  #   1 J� Effect1 5{  "   3  -System.Windows.Media.Effects.DropShadowEffect  5|  &   2   
BlurRadius$2 30Q�67   3   Opacity$	3 0.1Q�6G   4   Color$4 Black��6U   5   ShadowDepth$5 0Q�6c   5~     5�     5�     5�     5�     5�     5�     