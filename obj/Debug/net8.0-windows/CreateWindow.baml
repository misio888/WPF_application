   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.CreateWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  CreateWindow��5      $	��450��6    $	��800��6-   $��16(�69    � WindowStartupLocation$ CenterScreen=�6G   .��5	      � ���#49243E � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��2��6   $��Nowy Produkt ��6-   $
��Bold"�6E   $��36(�6W   $��2��6e   $��Center=�6y   $��Center=�6�   ���	#FFD8BFB66�   �� 5   
   $��6��6   $��3��6   $��Cena: ��6-   $
��Bold"�6>   $��Center=�6P   $��Center=�6m   ���	#FFD8BFB66�   �� 5   
   $��6��6   $��0��6   $��	Ilość: ��6-   $
��Bold"�6?   $��Center=�6Q   $��Center=�6n   ���	#FFD8BFB66�   �� 5    
   $��5��6   $��0��6   $��Nazwa: ��6-   $
��Bold"�6?   $��Center=�6Q   $��Center=�6n   ���	#FFD8BFB66�   �� 5!   
   $��2��6   $��0��6   $��	Zdjecie: ��6-   $
��Bold"�6A   $��Center=�6S   $��Center=�6p   ���	#FFD8BFB66�   �� 5$   
   -   5        $��txtName��5$      $��5��6!   $��1��6.   $��4��6>   $��4q�6R   �� 5%   
   -   5        $��
txtCountry��5%      $��6��6$   $��1��61   $��2��6A   $��4q�6U   �� 5'   
   -   5        $��imgPhoto��5'      $��2��6    $��3��6-   $��1��6>   $��4��6N   �� 5(   
   -   5        $��txtDescription��5(      $��6��6(   $��4��65   $��4q�6E   �� 5*   
   -   5        $��btnUploadPhot��5*      $��2��6&   $��1��63   $��Wczytaj zdjęcie��6D   $��4q�6^   6i   �� 5,   
   -   5        $��btnSav��5,      $��2��6   $��6��6,   $��Zapisz��6<   $��8q�6M   6Y   �� 5-   
   -   5        $��btnClose��5-      $��3��6!   $��6��6.   $��Zamknij��6>   $��8q�6g   5/      50      