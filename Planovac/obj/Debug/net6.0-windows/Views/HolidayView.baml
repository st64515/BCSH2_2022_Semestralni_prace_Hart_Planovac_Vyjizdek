   M S B A M L   `   `   `  ????C  ?Planovac, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Planovac.ViewsPlanovac.Views  5           Planovac.Views.HolidayView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Planovac.Views     5      
???????.??5      ? $??Center=?6   $??Center=?5        ? ColumnDefinitions  5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??Datum volna:??6   $??0??5      $??0??5      $??3q?5      $??Bottom=?5      ?? 5    
   $??Popis:??6   $??0??5!      $??3??5"      $??3q?5#      $??Center=?5$      &   System.Windows.Controls.Calendar  5&   
   $??1??6   $??0??5'      $??3q?5(      $??Center=?5*      $??Center=?5+         SelectedDate 5)      ??  ?? Path$ 	EventDate?5+      ?? 5,   
   -   5        $??textBoxEventName??50      $??1??5,      $??3??5-      $	??200??5.      $??5q?5/      $??Center=?52      $??Center=?53      ??51      ?? $ EventDescription? ?? Mode$ TwoWay=? ?? ValidatesOnExceptions$
 true?? ?? NotifyOnValidationError$
 true??53      ?? 54   
   $??1??6   $??6??55      $	??150??56      $??25??57      $??5q?58      $??Potvrdit a zapsat??59      ??5:      ?? *AddEventCommand+5;      5<      