   M S B A M L   `   `   `  ����N  JEntregaFinalOficial, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:EntregaFinalOficialEntregaFinalOficial  5   	   +    %EntregaFinalOficial.VentanaSecundaria   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:EntregaFinalOficial     5   	     � Title$  Ventana Secundaria��5   	   $	��450��6$   $	��800��61   
�������.��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��ListaElecciones��5      $��10q�6   $��0��66   $��2��6C    �� View 5      �� 5      .P�5      �� $��	ELECCIÓN��6%    �� Width$
 AUTO��67    �� DisplayMemberBinding 6D   �� *nombreEleccion+�� 5      $��FECHA��6%   $
 AUTO��64    6A   �� *fecha+�� 5      $��ESCAÑOS��6%   $
 AUTO��66    6C   �� *numeroEscaños+�� 5      $��MAYORÍA ABSOLUTA��6%   $
 AUTO��6?    6L   �� *mayoriaAbsoluta+5      5      �� 5   
   -   5        $��ListaPartidos��5      $��10q�6   $��1��64   $��1��6A    5      �� 5      .P�5       �� $��PARTIDO POLÍTICO��6%   $
 AUTO��6?    6L   �� *nombrePartido+�� 5!      $��ESCAÑOS��6%   $
 AUTO��66    6C   �� *
escaños+�� 5"      $��COLOR��6%   $
 AUTO��64    6A   �� *color+5$      5&      �� 5'   
   -   5        $��BotonAñadirEleccion��5'      $��10q�6   $��Añadir Eleccion��68   $��1��6R   $��1��6_   $	��Top=�5(   	   $��80��6!   
��� � �6-   �� 5)   
   -   5        $��BorrarElecciones��5)      $��10q�6   $��Borrar Elecciones��65   $��1��6Q   $��1��6a   $��Bottom=�5*   	   $��80��6$   
���  ��60   5+      5,      