   M S B A M L   `   `   `  ����O  KEquipmentsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:EquipmentsAccounting.windowsEquipmentsAccounting.windows  5   	   6    0EquipmentsAccounting.windows.ReportSettingWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:EquipmentsAccounting.windows     5   	   -   5          � Title$#  Редактор отчёта��5   	   $
��1000��5	   	   $	��780��6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��Настройки��6   $��15q�5      $��20(�5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      �� 5       .+�5$      �� $��Основа��6   $��16(�5%      $��	25,5,0,10q�5&      � 5(       � Orientation$ Vertical=�6   $��25,32,10,20q�5)      
�������.+�5,      	� -   5         	�Name$ AllEquipmentsRadioButton��5,      $%��Всё оборудование��5-      $��14(�5.      $��
30,30,0,10q�5/      50      	� 52      -   5        $  StockEquipmentsRadioButton��52      $��
Склад��53      $��14(�54      $��
30,30,0,10q�55      56      	� 58      -   5        $&  MaintenanceEquipmentsRadioButton��58      $&�� Тех. обслуживание��59      $��14(�5:      $��
30,30,0,10q�5;      5<      	� 5>      -   5        $# WriteOffEquipmentsRadioButton��5>      $��Списанное��5?      $��14(�5@      $��
30,30,0,10q�5A      5B      �� 5D      -   5         ��Name$  OnlyWithSerialNumsCheckBox��5D      $��14(�5E      $��
30,30,0,10q�5F      .��5H      �� �� 5J       �� TextWrapping$
 Wrap=�6%   $,��&Только с серийниками��5K   %   $	��133��5L   %   5N      5P      5R      �� 5U      $ ��Доп. настройки��6   $��16(�5V      $��	25,5,0,10q�5W      $��1��5X      � 5Z      -   5         �Name$# AdditionallySettingsWrapPanel��5[      $ Vertical=�5Z      $��25,32,10,20q�5\      
�������$��1��5^      {�.  .+�5a      	� -   5        $$ EquipmentsSerialNumRadioButton��5a      $#��Серийныйн номер��5b      $��14(�5c      $��	30,30,0,0q�5d       	� 	GroupName$ Group1��5e      5f      	� 5h      -	   5        $  EquipmentsCountRadioButton��5h      $��Кол-во��5i      $��14(�5j      $��
30,10,0,10q�5k      $ Group1��5l      5m      �� 5o      -
   5        $ EquipmentsPriceCheckBox��5o      $��Цена��5p      $��14(�5q      $��
30,15,0,10q�5r      �� 5t      -   5        $ EquipmentsSumCheckBox��5t      $��
Сумма��5u      $��14(�5v      $��	30,0,0,10q�5w      5y      �� 5{      -   5        $ NoDisponsalSumCheckBox��5{      $,��&Не считать списанное��5|      $��14(�5}      $��	30,0,0,20q�5~      {�.  5      �� 5�      -   5        $ DateCheckBox��5�      $��Дата��5�      $��14(�5�      $��30,0,0,0q�5�      {�.  5�      �� 5�      -   5        $ ReasonCheckBox��5�      $��Причина��5�      $��14(�5�      $��
30,10,0,10q�5�      {�.  5�      5�      5�      �� 5�   
   -   5        	 ��Name$	 
DoneButton��5�      $��2��5�      $��Готово��5�      $��Center=�5�      $��10q�5�      $��5,2,5,2q�5�      $��14(�5�      5�      &   System.Windows.Controls.DataGrid  5�   
   -   5        $��ReportDataGrid��5�      $��3��5�      $y�Visible=�5�      
   
IsReadOnly
 .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�      ��5�      ��    	CellStyle 5�      �� 5�       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   5�      5�      5�      5�      