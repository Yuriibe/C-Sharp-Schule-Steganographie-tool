   M S B A M L   `   `   `  ����  MyStegoTool)    #SteganographyToolUI.EncodeControler   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ���#1C1C1E  � 	Resources  5       �� 
TargetType   RoundedButtonStyle �� Property �� Value �� 
TargetType �� CornerRadius��%�   &	        �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $ 10��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5      5      5      5      .��5!      � .+�5$   
   ��  �� Orientation$ Vertical=�6   $��Center=�5%      $	��Top=�5&      $��10q�5'      .+�5(      �� $��Steganography Tool��6   $��32(�5)      $
��Bold"�5*      ���#8AC7DB$��Center=�5,      �� 5-      $1��+Visualizing Different Steganography Methods��6   $��16(�5.      ���#006D75$��Center=�50      $��0,5,0,20q�51      52      � 55   
   $��
20,0,20,20q�6   $��Center=�56       � ColumnDefinitions 57      �� 58      $��2* �6#   �� 59      $��2* �6#   .+�5=      �� $��0��6   $��Center=�5>      $��Center=�5?      .+�5@      �� -   5        $��
imgDisplay��5@      $	��300��5A      $	��300��5B      $��Center=�5C      $��Center=�5D      �� 5E      -   5        $��
Load Image��5E      $	��150��5F      $��40��5G      $��Center=�5H      $��	10,20,0,0q�5I      ���#2EC4B6
�������#��[  5L      5M      5N      �� 5Q      $��1��6   $��Center=�5R      $��Center=�5S      .+�5T      �� -   5         ��Name$ toggleSwitch��5T      $��Enable Demo Mode��5U      $��16(�5V      $
��Left=�5W      $��	0,10,0,20q�5X      	 d� 	IsChecked$	 FalseY�5Y      ���#2E2E2E
�������5]      �� 5_      $"��Choose Steganography Method:��6   $��18(�5`      $
��Left=�5a      $��0,0,0,10q�5b      
�������5c      �� 5e      -   5        $��MethodSelectionComboBox��5e      $	��250��5f      $
��Left=�5g      $��0,0,0,20q�5h      ���#2E2E2E.@�5m      �� $!��Least Significant Bit (LSB)��6#   �� 5n      $&�� Most Significant Bit (MSB) Demo-��6#   �� 5o      $��Future Method 2��6#   5p      �� 5r      -   5        
 ��Name$
 inputTextBox��5r      $	��250��5s      $	��150��5t      $
��Left=�5u      $	��Top=�5v       �� TextWrapping$
 Wrap=�5w       �� AcceptsReturn$
 True��5x      $��0,20,0,0q�5y      ���#2E2E2E
�������5{      5|      5}      �� 5�   
   $ 
Horizontal=�6   $��Center=�5�      $��Bottom=�5�      $��20q�5�      .+�5�      �� -   5        $��Encode��5�      $	��100��5�      $��40��5�      ���#00B4D8
�������#��[  5�      5�      5�      5�      5�      