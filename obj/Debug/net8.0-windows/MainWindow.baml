   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $��16(�65    � WindowStartupLocation$ CenterScreen=�6C   .��5	      � ���#49243E � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��133.333 �6   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   ���	#FFD8BFB6$��2��64   $��Menu ��6D   $��2��6T   $
��Bold"�6h   $��Center=�6z   $��Center=�6�   $��36(�6�   �� 5   
   $��2��6   ���	#FFD8BFB6$��0��64   $��
Zdjęcie: ��6D   $
��Bold"�6X   $��Center=�6j   $��Center=�6�   �� 5   
   $��1��6   ���	#FFD8BFB6$��0��64   $��	Wybierz: ��6D   $
��Bold"�6X   $��Center=�6j   $��Center=�6�   �� 5   
   $��8��6   ���	#FFD8BFB6$��2��64   $��Cena: ��6D   $
��Bold"�6U   $��Center=�6g   $��Center=�6�   �� 5    
   $��5��6   ���	#FFD8BFB6$��0��64   $��Nazwa: ��6D   $
��Bold"�6V   $��Center=�6h   $��Center=�6�   �� 5!   
   $��6��6   ���	#FFD8BFB6$��0��64   $��	Ilość: ��6D   $
��Bold"�6V   $��Center=�6h   $��Center=�6�   �� 5#   
   -   5        $��cmbListView��5#      $��1��6&   $��1��63   $��4��6C   $��12q�6W   6�   �� 5$   
   -   5        $��txtName��5$      $��5��6!   $��4q�6.   $��1��6:   $��4��6J   �� 5%   
   -   5        $��
txtCountry��5%      $��6��6$   $��1��61   $��4q�6A   �� 5'   
   -   5        $��imgPhoto��5'      $��2��6    $��1��6-   $��4��6=   $��3��6Q   $��4q�6b   �� 5(   
   -   5        $��txtDescription��5(      $��6��6(   $��3��65   $��2��6E   $��4q�6Y   �� 5)   
   -   5        $��	btnCreate��5)   8      ButtonStyle1#���   6   $��1��6I   $��6��6V   $��Utwórz��6f   $��8q�6w   6�   �� 5*   
   -   5        $��	btnUpdate��5*   8   #���   6   $��2��6I   $��6��6V   $��Zmień��6f   $��8q�6v   6�   �� 5+   
   -   5        $��	btnDelete��5+   8   #���   6   $��3��6I   $��6��6V   $��Usuń��6f   $��8q�6u   6�   �� 5,   
   -	   5        $��btnClose��5,   8   #���   6   $��4��6H   $��6��6U   $��Zamknij��6e   $��8q�6w   6�   5.      5/      