   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.UpdateWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  UpdateWindow��5   	   $	��450��6   $	��800��6+   $��16(�67    � WindowStartupLocation$ CenterScreen=�6E   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��9* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6   $��Nazwa: ��6-   $
��Bold"�6?   �� 5   
   $��0��6   $��3��6   $��
Państwo: ��6-   $
��Bold"�6A   �� 5   
   -   5        $��txtName��5      $��1��6!   $��2��6.   �� 5   
   -   5        $��
txtCountry��5      $��1��6$   $��3��61   �� 5!   
   -   5        $��imgPhoto��5!      $��2��6    $��0��6-   $��2��6=   �� 5"   
   -   5        $��txtDescription��5"      $��2��6(   $��2��65   $��2��6E    �� 
IsReadOnly$
 True��6Y   �� 5$   
   -   5        $��btnUploadPhoto��5$      $��3��6'   $��0��64   $��Wczytaj zdjęcie��6D   �� 5&   
   -   5        $��btnSave��5&      $��3��6    $��2��6-   $��Zapisz��6=   �� 5'   
   -   5        $��btnClose��5'      $��3��6!   $��3��6.   $��Zamknij��6>   6P   5)      5*      