   M S B A M L   `   `   `  ����H  DPruebaTecnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PruebaTecnicaPruebaTecnica  5   	       PruebaTecnica.BuscarPago   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PruebaTecnica     5   	     � Title$  
BuscarPago��5   	   $	��668��6   $
��1074��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6"   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      $��40 �6   6*   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��3��6   $��
ExtraBlack"�6$   $��25(�6<   $��Center=�6J   .��6g   	REPORTE6p   �� 5   
   $��0��6   $��1��6    $��14(�6-   $
��Bold"�6;   .��6M   DNI6R   �� 5   
   -   5        $��DNiBusqueda��5      $��1��6%   $��1��66   �� 5    
   -   5        $��2��5       $��1��6!   $��10q�6.   .��6P   buscar6X   �� 5"   
   $��0��6   $��2��6    $��14(�6.   $
��Bold"�6<   .��6N   	Nombres6W   �� 5#   
   -   5        $��NombresYApe��5#      $��1��6%   $��2��66   �� 5'   
   -   5        $��0��5'      $��8��6!   $��Black"�6/   $��10q�6W   .��6c   Crear Reporte6r   �� 5(   
   -   5        $��2��5(      $��8��6!   $��Black"�6/   $��10q�6Y   .��6e   
Cancelar6o   �� 5)   
   -   5        $��Datos��5)      $��3��6    $��3��6Y   $��4��6m   $��14(�6~   $��Center=�6�   $��Center=�6�   $��Center=�6�   $	��340��6�   $	��900��6�   $��Center=�6    �� View 5*      �� 5+      .P�5,      �� $��Cuotas��6%    �� Width$ 60��65    �� DisplayMemberBinding 6@   �� *	cuotasP+�� 5-      $��Fecha��6%   $	 200��64    6@   �� *fechaP+�� 5.      $��Capital��6%   $	 200��66    6B   �� *
capitalC+�� 5/      $��	Intereses��6%   $	 200��68    6D   �� *
interesesP+�� 50      $��Monto Cuota��6%   $	 240��6:    6F   �� *
montoCuota+51      53      54      55      