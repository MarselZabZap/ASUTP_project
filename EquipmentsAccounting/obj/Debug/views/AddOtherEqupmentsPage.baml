   M S B A M L   `   `   `  ����O  KEquipmentsAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EquipmentsAccounting.viewsEquipmentsAccounting.views  5      6    0EquipmentsAccounting.views.AddOtherEqupmentsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:EquipmentsAccounting.views     5        N� Title$  AddOtherEqupmentsPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   � $��0��6    � Orientation$ Vertical=�5      $��Center=�5      $��Center=�5      .+�5      �� $��0��6   $��Количество��5      $��14(�5      $��Center=�5      �� 5       -   5         ��Name$ CountTextBox��5       $��5,0,5,0q�5!      $��10,0,0,0q�5"      $��35��5#      $��0��5$      $��14(�5%      $��Center=�5&      5(      � 5,   
   $��1��6   .+�5.      � $ 
Horizontal=�6   $��Center=�5/      $��Center=�50      $��1q�51      .+�53      �� -   5         ��Name$ 	AddButton��53      $��Добавить��54      $��16(�55      $��5q�56      $��
0,10,20,10q�57      58      �� 5:      -   5        $ CancelChangeButton��5:      $��Закрыть��5;      $��16(�5<      $��5q�5=      $��
30,10,0,10q�5>      $��Close��5?      5A      5C      �� 5E   
   -   5         ��Name$ Notification��5E       �� Orientation$ 
Horizontal=�5F      $��1��5G      
������$��25��5I      $��Bottom=�5J      $y�	Collapsed=�5K      .+�5M      �� $1��+Оборудование добавлено��6   $��10,0,0,0q�5N      $��Center=�5O      5Q      5S      5T      