   M S B A M L   `   `   `  ����H  DPruebaTecnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:PruebaTecnicaPruebaTecnica  5   	        PruebaTecnica.CrearCliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:PruebaTecnica     5   	     � Title$  CrearCliente��5   	   $	��550��6   $	��480��6+   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��2��6   $��
ExtraBlack"�6$   $��25(�6<   $��99,12,107,20q�6J   .��6`   CREAR CLIENTE6o   �� 5   
   $��0��6   $��1��6    $��56,30,20,15q�6-   $��14(�6B   $
��Bold"�6P   .��6b   DNI6g   �� 5   
   -   5        $��txtDNI��5      $��1��6    $��1��61   $��16,30,17,15q�6>   �� 5   
   $��0��6   $��2��6    $��56,30,20,15q�6-   $��14(�6B   $
��Bold"�6P   .��6b   	Nombres6k   �� 5   
   -   5        $��
txtNombres��5      $��1��6$   $��2��65   $��16,30,17,15q�6B   �� 5!   
   $��0��6   $��3��6    $��56,30,20,15q�6-   $��14(�6B   $
��Bold"�6P   .��6b   	Apellidos6m   �� 5"   
   -   5        $��txtApellidos��5"      $��1��6&   $��3��67   $��16,30,17,15q�6D   �� 5$   
   $��0��6   $��4��6    $��56,30,20,15q�6-   $��14(�6B   $
��Bold"�6P   .��6b   Fecha Nacimiento6t   (  "System.Windows.Controls.DatePicker  5%   
   -   5        $��dateNacimiento��5%      $��1��6+   $
��Left=�6;   $��	22,29,0,0q�6V   $��4��6i   $	��Top=�6v      SelectedDateFormat$ Short=�6�   �� 5)   
   -   5        $��0��5)      $��6��6!   $��20q�6.   $��Black"�6:   .��6b   	Guardar6k   �� 5*   
   -   5        $��1��5*      $��6��6!   $��20q�6.   $��Black"�6:   .��6d   
Cancelar6n   5,      5-      