   M S B A M L   `   `   `  ����  Planovac     Planovac.Views.EventDetail   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  eventDetailControl��5	      .��5
      � $
��auto��5      $��Center=�5      $��Center=�5       � DataContext 5
      ��  �� ElementName$ eventDetailControl�� �� Path$ DataContext� � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � -   5        $��grid1��5      $��0��5       5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Datum události:��6   $��0��5       $��0��5!      $��3q�5"      $��Bottom=�5#      �� 5$      $��Čas začátku:��6   $��0��5%      $��1��5&      $��3q�5'      $��Center=�5(      �� 5)      $��Čas konce:��6   $��0��5*      $��2��5+      $��3q�5,      $��Center=�5-      �� 5.      $��Popis:��6   $��0��5/      $��3��50      $��3q�51      $��Center=�52      �� 53      $��Vedoucí jezdec:��6   $��0��54      $��4��55      $
��Left=�56      $��3q�57      $��Center=�58      &   System.Windows.Controls.Calendar  59      $��1��6   $��0��5:      $��3q�5;      $��Center=�5=      $��Center=�5>         SelectedDate 5<      �� $
 Date�5>      �� 5?      -   5        $��textBoxEventTimeStart��5C      $��1��5?      $��1��5@      $	��200��5A      $��3q�5B      $��Center=�5E      $��Center=�5F      ��5D      �� $ 	StartTime� �� Mode$ TwoWay=� �� ValidatesOnExceptions$
 true��	 �� NotifyOnValidationError$
	 true��5F      �� 5G      -   5        $��textBoxEventTimeEnd��5K      $��1��5G      $��2��5H      $	��200��5I      $��4q�5J      $��Center=�5M      $��Center=�5N      ��5L      �� $ EndTime�$ TwoWay=�$
 true��$
	 true��5N      �� 5O      -   5        $��textBoxEventName��5S      $��1��5O      $��3��5P      $	��200��5Q      $��5q�5R      $��Center=�5U      $��Center=�5V      ��5T      �� $ Description�$ TwoWay=�$
 true��$
	 true��5V      �� 5W      $��1��6   $��4��5X      $	��200��5Y      $��5q�5Z      $��Center=�5\      $��Center=�5]      ��5[      �� $ MasterRider�$ TwoWay=�$
 true��$
	 true��5]      5^      � 5_   
   -   5        $��grid2��5_      $��1��5`      $��Center=�5a       5b      �� 5c      $
��Auto �6    �� 5d      $	��250 �6    �� 5e      $
��Auto �6    �� 5f      $
��Auto �6    �� 5g      $
��Auto �6    .+�5j      �� $��Seznam koní:��6   $��0��5k      �� 5l      $��1��6   $	��100��5n      ��5m      �� $ Horses���5o      �� 5p      .R�5q      �� ��6$   �� 5r      5t      �� 5�      $��3��6   $	��100��5�      $��25��5�      $��5q�5�      $��Potvrdit��5�      5�      5�      5�      