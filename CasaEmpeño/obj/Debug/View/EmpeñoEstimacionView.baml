   M S B A M L   `   `   `  ����F  BCasaEmpeño, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CasaEmpeño.ViewCasaEmpeño.View  5   	   ,    &CasaEmpeño.View.EmpeñoEstimacionView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CasaEmpeño.View     5   	     � Title$  EmpeñoEstimacionView��5   	   $	��450��6&   $	��800��63    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   $��2q�6    J� Opacity$
 0.95Q�63   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ White��6   	 � Offset$		 0.2Q�6-   5      ._�5   
   � 
 � RowDefinitions
 5      �� 5      $��30 �6    �� 5      .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      �� 5       $��25 �6'   �� 5!      $��25 �6'   �� 5"      $��5 �6'   .+�5$      �� $��ESTIMACIÓN DEL PRECIO��6   
���   �$��15(�5&      $��
Montserrat)�5'      $��0��5(      $��Center=�5)      $��10,0,0,0q�5*      �� 5,      -   5         ��Name$ btnMinimizar��5,      $��-��5-      
�������$��16(�5/      $��
Montserrat)�50       � Cursor$
 Hand��51      $��1��52      ��54      �� 55       �� 
TargetType" ��6    .�56      ��  �� Property � �� �� Value
 �   �6;    �� Triggers 57      P� 58   "    P� Property �@J�IsMouseOver P� Value . . �59   &   ��  � ��
 ��+��6C   5:   #   5<      ��5>      �� 5?       �� 
TargetType" ��6*   .R�5@      �� $��18��6%   $��18��60   $ 9��6<   #��z��6M   ._�5A   "   �� $��Center=�63   $��Center=�6N   5B      5C      5E      �� 5G      -   5        $ 	btnCerrar��5G      $��X��5H      
�������$��16(�5J      $��
Montserrat)�5K      $
 Hand��5L      $��2��5M      ��5O      �� 5P      " ��6    .�5Q      ��  � ��
 �   �6;    5R      P� 5S   "    �@J�IsMouseOver . . �5T   &   ��  � ��
 �  ��6C   5U   #   5W      ��5Y      �� 5Z      " ��6*   .R�5[      �� $��18��6%   $��18��60   $ 9��6<   #��z��6M   ._�5\   "   �� $��Center=�63   $��Center=�6N   5]      5^      5`      5a      �� 5b      $	��220��6   $��1��6%    �� Orientation$ Vertical=�62   $��Center=�6I   $	��Top=�6f   $��	0,20,0,20q�6~   
�������.+�5c      �� $	��200��5d      $	��100��5e      $.��(Se estimo que el precio del articulo es ��5f       �� TextAlignment$ Center=�5g      $
��Wrap=�5h      $��26(�5i      �� 5j      $	��200��6   $��?��6(   $��26(�61   $ Center=�6?   
�������6V   �� 5k      $	��200��6   $��10��6(   5l      �� 5m      $��1��6   $ Vertical=�6&   $��Center=�6=   $��Center=�6Z   $��	0,20,0,20q�6u   .+�5n      �� $'��!¿Desea continuar con este precio��6   $ Center=�6D   $
��Wrap=�6[   $��26(�6o   $��0,60,0,0q�6}   �� 5o      $	��180��6   $��	Continuar��6%   $��18(�69   
�������
���   �$��	0,10,0,20q�6m   �� 5p      $	��180��6   $��Regresar��6%   $��18(�68   
�������
���   �$��0,0,0,20q�6l   5q      5r      5s      5t      