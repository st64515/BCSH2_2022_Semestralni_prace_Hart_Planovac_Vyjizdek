   M S B A M L   `   `   `  ����  Planovac     Planovac.Views.RiderDetail   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          >�Name$  riderDetailControl��5	      .��5
      �  � DataContext 6   ��  �� ElementName$ riderDetailControl�� �� Path$ DataContext�.+�5   
   � -   5        $��grid1��5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Jméno:��6   $��0��5      $��0��5      $��3q�5      $��Center=�5      �� 5      -   5        $��riderFirstName��5      $��1��5      $��0��5      $��3q�5      $��Center=�5!      ��5       �� $ 	FirstName� �� Mode$ TwoWay=� �� ValidatesOnExceptions$
 true�� �� NotifyOnValidationError$
 true��5!      �� 5"      $��Příjmení:��6   $��0��5#      $��1��5$      $��3q�5%      $��Center=�5&      �� 5'      -   5        $��riderLastName��5*      $��1��5'      $��1��5(      $��3q�5)      $��Center=�5,      ��5+      �� $ LastName�$ TwoWay=�$
 true��$
 true��5,      �� 5-      $��Má licenci:��6   $��0��5.      $��2��5/      $��3q�50      $��Center=�51      �� 52      -   5        $��riderHasLicense��55      $��1��52      $��2��53      $��3q�54      $��Center=�57      ��56      �� $ 
HasLicense�$ TwoWay=�$
 true��$
 true��57      �� 58      $��Má 18:��6   $��0��59      $��3��5:      $��3q�5;      $��Center=�5<      �� 5=      -   5        $��riderIsAdult��5@      $��1��5=      $��3��5>      $��3q�5?      $��Center=�5B      ��5A      �� $ IsAdult�$ TwoWay=�$
 true��$
 true��5B      �� 5C      $��Popis:��6   $��0��5D      $��4��5E      $
��Left=�5F      $��3q�5G      $��Center=�5H      �� 5I      -   5        $��riderDescription��5L      $��1��5I      $��4��5J      $��3q�5K      $��Center=�5N      ��5M      �� $ Description�$ TwoWay=�$
 true��$
 true��5N      5O      5P      5Q      