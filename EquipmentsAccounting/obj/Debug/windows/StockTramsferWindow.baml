   M S B A M L   `   `   `  ����O  KEquipmentsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:EquipmentsAccounting.windowsEquipmentsAccounting.windows  5   	   6    0EquipmentsAccounting.windows.StockTramsferWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:EquipmentsAccounting.windows     5   	     � Title$  StockTramsferWindow��5   	   $	��750��6%   $
��1000��62   $	��750��5	   	   $
��1000��6   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      .+�5   
   � $��0��6    � Orientation$ Vertical=�5      .+�5      �� $��Отправитель��6   $��16(�5      $��
15,10,0,15q�5      $��0q�5      �� 5      -   5         ��Name$ SenderComboBox��5      $��14(�5       $	��400��5!      $��25��5"      $
��Left=�5#      $��	15,0,0,15q�5$      $��Center=�5%      5&      � 5(      $ 
Horizontal=�6   .+�5*      � $ Vertical=�6   .+�5+      �� $��Фильтрация��6    $��Center=�5,       $��14(�5-       $��	15,0,0,10q�5.       �� 50      -   5         ��Name$ FilterTextBox��50      $��14(�51      $��	15,0,0,20q�52      $
��Left=�53      $	��200��54      $��20��55      56      57      � 59      $ Vertical=�6   $��Center=�5:      .+�5<      	� -   5         	�Name$ TypeRadioButton��5<   "    d� 	IsChecked$
 TrueY�5=   "   $��По типу��5>   "   $��	10,0,10,0q�5?   "   	� 5A      -   5        $ CharsRadioButton��5A   "   $)��#По характеристикам��5B   "   $��	10,0,10,0q�5C   "   	� 5E      -   5        $ SerialNumRadioButton��5E   "   $*��$По серийному номеру��5F   "   $��	10,0,10,0q�5G   "   5H      5I      &   System.Windows.Controls.DataGrid  5K      -   5          Name$ SendersEquipmentDataGrid��5K      	   
IsReadOnly	 . 
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 5N      $��	15,0,0,20q�5O      ��5L      ��    	CellStyle 5P      �� 5Q       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5R      -   5        5S      5U      5V      � 5X   
   $ 
Horizontal=�6   $��1��5Y      $��Bottom=�5Z      .+�5\      �� $���{E:\!АСУТП Проект!\PROJECT\EquipmentsAccounting(Desktop) Отлаженая версия\img\arrow_right_icon.png��6   $��25��5]      $��25��5^      $��	0,0,0,230q�5_      5`      � 5b   
   $ Vertical=�6   $��2��5c      .+�5e      �� $��Получатель��6   $��16(�5f      $��
15,10,0,15q�5g      $��0q�5h      �� 5j      -   5        $ RecevierComboBox��5j      $��14(�5k      $	��400��5l      $��25��5m      $
��Left=�5n      $��	15,0,0,20q�5o      $��Center=�5p      {�.  5r      �� 5t      -	   5         ��Name$ 
ClearImage��5t      ${��uE:\!АСУТП Проект!\PROJECT\EquipmentsAccounting(Desktop) Отлаженая версия\img\clear_icon.png��5u      $��25��5v      $��25��5w      $��Right=�5x      $��
15,10,0,15q�5y      5z        5}      -
   5        $ RecevierEquipmentDataGrid��5}      	 . $
 * 5�      $��	15,0,0,20q�5�      ��5~      ��  5�      �� 5�      "  6   .�5�      -   5        5�      5�      5�      �� 5�   
   -   5         ��Name$ ApplyButton��5�      $��Передать��5�      $��1��5�      $��0��5�      $��Right=�5�      $��14(�5�      $��	15,5,15,5q�5�      $��0,0,0,15q�5�      5�      �� 5�   
   -   5        $ CancelButton��5�      $��1��5�      $��2��5�      $
��Left=�5�      $��Отмена��5�      $��14(�5�      $��	15,5,15,5q�5�      $��0,0,0,15q�5�      5�      5�      5�      