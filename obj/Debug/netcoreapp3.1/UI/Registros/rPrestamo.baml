   M S B A M L   `   `   `  ����L  HRegistro_prestamo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Registro_prestamo.UI.RegistrosRegistro_prestamo.UI.Registros  5   	   .    (Registro_prestamo.UI.Registros.rPrestamo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Registro_prestamo.UI.Registros     5   	     � Title$  Prestamo��5   	   $	��600��6   $	��600��6'   .��5	      � .+�5
   
   �� $��Center=�6   $��Center=�61   .+�5      �� $��PrestamoId:��6   $
��Bold"�6+   $
��14px(�6>   $��120,-125,1,1q�6N   $��SimSun-ExtB)�6d   $��Normal$�6}   �� 5      -   5         ��Name$ PrestamoIdTextBox��5      $��50��6M   $��25��6X   $��20,-140,0,0q�6d   ��61   �� *
PrestamoId+6d   �� 5      -   5         ��Name$ BuscarButton��5      $��190,-225,0,0q�6,   $	��100��6B   $��30��6N   $��Buscar��6Z   6k   �� 5      $��/Imagenes/Buscar.png��6   $��25��63   $��25��6>   $��130,-225,0,0q�6K   �� 5      $��	PersonaId��6   $
��Bold"�6)   $
��14px(�6<   $��110,-90,1,1q�6L   $��SimSun-ExtB)�6a   $��Normal$�6z   �� 5      -   5        $ PersonasIdTextBox��5      $��50��6M   $��25��6X   $��10,-225,0,0q�6d   ��61   �� *
PersonasId+6d   �� 5      $��Concepto��6   $
��Bold"�6(   $
��14px(�6;   $��110,-50,1,1q�6K   $��SimSun-ExtB)�6`   $��Normal$�6y   �� 5      -   5        $ ConceptoTextBox��5      $	��190��6I   $��25��6U   $��150,-80,0,0q�6a   ��6/   �� *
Concepto+6a   �� 5      $��Balance��6   $
��Bold"�6'   $
��14px(�6:   $��110,-20,1,1q�6J   $��SimSun-ExtB)�6_   $��Normal$�6x   �� 5      -   5        $ BalanceTextBox��5      $	��190��6G   $��25��6S   $��150,-50,0,0q�6_   ��6.   �� *	Balance+6_   �� 5      $��Monto��6   $
��Bold"�6%   $
��14px(�68   $��
110,10,1,1q�6H   $��SimSun-ExtB)�6\   $��Normal$�6u   �� 5      -   5        $ MontoTextBox��5      $	��190��6C   $��25��6O   $��150,-30,0,0q�6[   ��6,   �� *Monto+6[   �� 5!      $��Fecha��6   $
��Bold"�6%   $
��13px(�68   $��110,100,1,1q�6H   $��SimSun-ExtB)�6]   $��Normal$�6v   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ FechaTextBox��5"         Text$ (Binding Fecha)��6/   $	��190��6F   $��35��6R   $��150,-20,0,0q�6^   �� 5'      -   5        $ NuevoButton��5'      $��-120,20,0,0q�6+   $	��100��6@   $��40��6L   $�� Nuevo��6X   6i   �� 5(      $��/Imagenes/Nuevo.png��6   $��40��62   $��40��6=   $��-187,-40,0,0q�6J   �� 5*      -	   5        $ GuardarButton��5*      $��140,-40,0,0q�6-   $	��100��6B   $��40��6P   $��Guardar��6^   6p   �� 5+      $��/Imagenes/Guardar.png��6   $��35��63   $��35��6>   $��
75,-40,0,0q�6K   �� 5-      -
   5        $ EliminarButton��5-      $��390,-40,0,0q�6.   $	��100��6C   $��40��6Q   $��Eliminar��6_   6r   �� 5.      $��/Imagenes/Borrar.png��6   $��30��63   $��30��6>   $��330,-40,0,0q�6K   5/      51      52      