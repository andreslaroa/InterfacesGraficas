   M S B A M L   `   `   `  ����N  JEntregaFinalOficial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EntregaFinalOficialEntregaFinalOficial  5   	   +    %EntregaFinalOficial.VentanaElecciones   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EntregaFinalOficial     5   	     � Title$  Introduccion de datos��5   	   $	��450��6'   $	��800��64   
�������.��5	      � $��30q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $��10 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Nombre Elección��6   $��0��6*   $��0��67   $��14(�6G   $��Italic$�6U   $
��Bold"�5      �� 5   
   $��Fecha��6   $��2��6    $��0��6-   $��14(�6=   $��Italic$�6K   $
��Bold"�5      �� 5   
   $��Numero de Escaños��6   $��4��6,   $��0��69   $��14(�6I   $��Italic$�6W   $
��Bold"�5      �� 5   
   -   5        $��NombreEleccion��5      $,��&Introduzca el nombre de las elecciones��6(   $��0��5       $��1��6   $
��Auto��6/   $��Italic$�6<   $
��Bold"�6O   (  "System.Windows.Controls.DatePicker  5!   
   -   5        $��Fecha��5!         SelectedDate$ 
2002-03-13X�6"   $��2��6<   $��1��6I   $
��Auto��6Y   $��Italic$�5"      $
��Bold"�6(   �� 5#   
   -   5        $��NumeroEscaños��5#      $'��!Introduzca el número de escaños��6'   $��4��6N   $��1��6[   $��Italic$�5$      $
��Bold"�6%   $
��Auto��67   �� 5%   
   -   5        $��AñadirPartidoYEscaños��5%      $ ��Añadir Partido y escaños��6.   $��13��6Q   $��0��6_   $	��100��5&      $	��264��6   $	��Top=�6+   $��Right=�6C   $��20(�5'      
��� ���6   �� 5(   
   -   5        $��ListaPartidos��5(      $��10q�6   $��10��64   $��1��6B   $
��Auto��6�    �� View 5)      �� 5*      .P�5+      �� $��PARTIDO POLÍTICO��6%    �� Width$
 AUTO��6?    �� DisplayMemberBinding 6L   �� *nombrePartido+�� 5,      $��ESCAÑOS��6%   $
 AUTO��66    6C   �� *
escaños+�� 5-      $��COLOR��6%   $
 AUTO��64    6A   �� *color+5/      51      �� 52   
   -   5        $��AñadirEleccion��52      $��Añadir eleccion��6'   $��13��6A   $��0��6O   $��Bottom=�6_   $	��100��53      $
��Auto��6   
��� � �$��20(�6>   6L   �� 54   
   -   5        $��BorrarPartido��54      $��Borrar Partido��6&   $��13��6?   $��0��6M   $��Center=�6]   $��80��55      $
��Auto��6   
���  ��$��20(�6;   6I   56      57      