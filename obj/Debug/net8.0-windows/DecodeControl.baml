   M S B A M L   `   `   `  ����  MyStegoTool)    #SteganographyToolUI.DecodeControler   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ���#1C1C1E  � 	Resources  5       �� 
TargetType   RoundedButtonStyle �� Property �� Value �� 
TargetType �� CornerRadius��%�   &	        �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $ 10��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5      5      5      5      .��5       � .+�5#   	   ��  �� Orientation$ Vertical=�6   $��Center=�5$      $	��Top=�5%      $��10q�5&      .+�5'      �� $��Steganography Tool��6   $��32(�5(      $
��Bold"�5)      ���#8AC7DB$��Center=�5+      �� 5,      $1��+Visualizing Different Steganography Methods��6   $��16(�5-      ���#006D75$��Center=�5/      $��0,5,0,20q�50      51      � 54   
   $��
20,0,20,20q�6   $��Center=�55       � ColumnDefinitions 56      �� 57      $��2* �6#   �� 58      $��2* �6#   .+�5<      �� $��0��6   $��Center=�5=      $��Center=�5>      .+�5?      �� -   5        $��
imgDisplay��5?      $	��300��5@      $	��300��5A      $��Center=�5B      $��Center=�5C      �� 5D      -   5        $��
Load Image��5D      $	��150��5E      $��40��5F      $��Center=�5G      $��	10,20,0,0q�5H      ���#2EC4B6
�������#��[  5K      5L      5M      �� 5P      $��1��6   $��Center=�5Q      $��Center=�5R      .+�5S      �� -   5         ��Name$ toggleSwitch��5S      $��Enable Demo Mode��5T      $��16(�5U      $
��Left=�5V      $��	0,10,0,20q�5W      	 d� 	IsChecked$	 FalseY�5X      
����������#2E2E2E5\      �� 5^      $"��Choose Steganography Method:��6   $��18(�5_      $
��Left=�5`      $��0,0,0,10q�5a      
�������5b      �� 5d      -   5        $��MethodSelectionComboBox��5d      $	��250��5e      $
��Left=�5f      $��0,0,0,20q�5g      .@�5h      �� $!��Least Significant Bit (LSB)��6#   �� 5j      $&�� Most Significant Bit (MSB) Demo-��6#   �� 5k      $��Future Method 2��6#   5l      �� 5m      $
��Auto=�6   $��Disabled=�6B   .��5n      �� -   5        $��decodedText��5r      $/��)This is a text block. It is non-editable.��5n      $��16(�5o      
 �� TextWrapping$

 Wrap=�5p      $��10q�5q      $	��250��5s      $	��150��5t      $
��Left=�5u      $	��Top=�5v      " �� VerticalScrollBarVisibility$
 Auto=�5w       �� 
IsReadOnly$
 True��5x      $��0q�5y      $��0,20,0,0q�5z      
������ 
�������5|      5~      5      5�      �� 5�   
   $ 
Horizontal=�6   $��Center=�5�      $��Bottom=�5�      $��20q�5�      .+�5�      �� -   5        $��Decode��5�      $	��100��5�      $��40��5�      ���#FF4C4C
�������#��[  5�      5�      5�      5�      5�      