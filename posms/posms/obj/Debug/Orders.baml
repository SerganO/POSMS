   M S B A M L   `   `   `  ����@  <posms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:posmsposms  5   	       posms.Orders   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   !localclr-namespace:posms   5   	     � Title$  Orders��5	   	   $	��600��6   $	��600��6%    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�6G    � Icon$" Resources/sisense2-copy1.png��6l   ��5
      �� 5   
    �� ImageSource$! Resources/Background1-1.png��6   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $
��1.5* �6   6,   �� 5      $��6* �6   6*   �� 5      $
��1.5* �6   6,   .+�5   
   �� -   5         ��Name$ Orders_list��5      $��1��6(   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Orders��5      ���	#89118125 &  "MaterialDesignFloatingHintComboBox#��[  5      $��24(�6?   $��Bottom=�6M   $��
20,0,20,10q�6h   ���	#FFCED2CE5      �� 5   
   -   5         ��Name$  Only_not_delivered_checked��5      $��0��67     MaterialDesignCheckBox#��[ 5      $��18(�65   $��Center=�6C   $��Right=�6^   $��0,0,20,0q�6z   ���	#FFFAD003���	#FFFAD003.��6�   Only Not Delivered5      �� 5   
   -   5        $��0��5       " MaterialDesignRaisedDarkButton#��[ 5       $	��100��5!      $��40��6   $��26(�6   	 � ToolTip$	 Back to Main Window��5"      $	��Top=�6#   $
��Left=�6;   $��	10,10,0,0q�6V   ���	#FFE05900���	#FFE05900.��6�   _Back5$      &   System.Windows.Controls.DataGrid  5&   
   -   5        
  Name$
 
ListOrders��5'      $��2��5(      $��
20 10 20 0q�5)      $��26(�6      CanUserSortColumns .    CanUserAddRows .  ���	#FFCED2CE��5*      �� *Items3+5,      �� 5.   
   -   5        $��3��5.      #��[ 5/      $	��150��50      $��40��6   $��26(�6   $	 Confirm good��51      $��Center=�6   $��Center=�67   ���	#FF0C7106���	#FF0C7106.��6�   
_Confirm53      55      56      