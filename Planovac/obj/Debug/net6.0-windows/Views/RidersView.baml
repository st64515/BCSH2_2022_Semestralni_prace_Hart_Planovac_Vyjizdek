   M S B A M L   `   `   `  ����C  ?Planovac, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Planovac.ViewsPlanovac.Views  5      9!clr-namespace:Planovac.ViewModelsPlanovac.ViewModels  5          Planovac.Views.RidersView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Planovac.Views     5      8
viewmodels!clr-namespace:Planovac.ViewModels     5      .��5      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ master��5         AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         CanUserDeleteRows$
 True��5      $��0��5      ��5      �� *Riders+ �� SelectedItem 5      �� *SelectedRider+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        riderFirstName��,  &System.Windows.Controls.DataGridColumn   Header$ Jméno��5   %   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 5   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   %   ��  �� Path$ 	FirstName�5   %     5      -   5        riderLastName��$ Příjmení��5    %   $		 160 5!   %   
 5   %   �� $ LastName�5!   %     5"      -   5        
hasLicense��$ Má licenci��5$   %   $	 80 5%   %   
 5#   %   �� $ 
HasLicense�5%   %     5&      -   5        isAdult��$ 
Má 18 let��5(   %   $	 80 5)   %   
 5'   %   �� $ IsAdult�5)   %     5*      -   5        Description��$ Popis��5,   %   $	 * 5-   %   
 5+   %   �� $ Description�5-   %   5/          Planovac.Views.RiderDetail  51   
   -   5          Name$ riderDetail��54      $��1��51      $��5q�53       � DataContext 52      �� *SelectedRider+54      �� 56   
    �� Orientation$ 
Horizontal=�6   $��Right=�57      $��5q�58      $��3��59      .+�5:      �� $	��100��6   $��25��5;      $��5q�5<      $��Přidat jezdce��5=      ��5>      �� *
AddCommand+�� 5?      $	��100��6   $��25��5@      $��5q�5A      $��Odebrat jezdce��5B      ��5C      �� *RemoveCommand+5D      5E      5F      