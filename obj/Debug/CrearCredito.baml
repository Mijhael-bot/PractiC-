   M S B A M L   `   `   `  ����H  DPruebaTecnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PruebaTecnicaPruebaTecnica  5   	        PruebaTecnica.CrearCredito   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PruebaTecnica     5   	     � Title$  CrearCredito��5      $	��550��6   $	��480��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��1��6   $��1��6     5      �� 5      6%   �� 5      6%   .+�5       �� -   5        $��1��5       .��6;   Buscar6C   �� 5!      -   5        $��	BuscarDni��5!      $��0��6'   5"      �� 5$   
   $��2��6   $��
ExtraBlack"�6$   $��25(�6<   $��Center=�6J   .��6g   CREAR CREDITO6v   �� 5&   
   $��0��6   $��1��6    $��14(�6-   $
��Bold"�6;   .��6M   DNI6R   �� 5)   
   $��0��6   $��2��6    $��14(�6.   $
��Bold"�6<   .��6N   	Nombres6W   �� 5*   
   -   5        $��NombreBuscado��5*      $��1��6'   $��2��68   �� 5,   
   $��0��6   $��3��6    $��14(�6.   $
��Bold"�6<   .��6N   	Apellidos6Y   �� 5-   
   -   5        $��ApellidoBuscado��5-      $��1��6)   $��3��6:   �� 5/   
   $��0��6   $��4��6    $��14(�6-   $
��Bold"�6;   .��6M   Monto6T   �� 50   
   -   5        $��MontoCreacion��50      $��1��6'   $��4��68   �� 52   
   $��0��6   $��5��6    $��14(�6.   $
��Bold"�6<   .��6N   Numero de Cuotas6`   �� 53   
   -   5        $��	NumCuotas��53      $��1��6$   $��5��65   �� 55   
   $��0��6   $��6��6    $��14(�6.   $
��Bold"�6<   .��6N   Tasa Efectiva Anual6c   �� 56   
   -   5        $��
teaCreacon��56      $��1��6%   $��6��66   �� 58   
   $��0��6   $��7��6    $��14(�6.   $
��Bold"�6<   .��6N   	Interes6W   �� 59   
   -   5        $��InteresesCrea��59      $��1��6'   $��7��68   �� 5;   
   $��0��6   $��8��6    $��14(�6-   $
��Bold"�6;   .��6M   Fecha Creacion6]   (  "System.Windows.Controls.DatePicker  5<   
   -	   5        $��dateCreacion��5<      $��1��6)   $
��Left=�69   $��8��6U   $	��Top=�6b      SelectedDateFormat$ Short=�6z   �� 5?   
   -
   5        $��0��5?      $��9��6!   $��Black"�6/   .��6Y   	Guardar6b   �� 5@   
   -   5        $��1��5@      $��9��6!   $��Black"�6/   .��6W   
Cancelar6a   5B      5D      