   M S B A M L   `   `   `  ����@  <posms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:posmsposms  5   	       posms.AddToOrder   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   !localclr-namespace:posms   5   	     � Title$  
AddToOrder��5	   	   $	��450��6   $	��450��6,   $	��450��6;   $	��450��6H    � 
ResizeMode$ NoResize=�6T    � WindowStartupLocation$ CenterScreen=�6j    � Icon$" Resources/sisense2-copy1.png��6�   ��5
      �� 5   
    �� ImageSource$! Resources/Background1-2.png��6   .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   6*   �� 5      $��3* �6   6*   �� 5      $
��2.5* �6   6,   �� 5      $
��1.5* �6   6,   .+�5   
   �� -   5         ��Name$ Provider_list��5      $��0��6*   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Provider��5      ���	#FFCDD2CC���	#FFCDD2CC &  "MaterialDesignFloatingHintComboBox#��[  5      $��24(�6?   $��Bottom=�6M   $��
20,0,20,10q�6h   5      �� 5   
   -   5        $ 	Good_list��5      $��1��6&   $
 Good��5      ���	#FFCDD2CC���	#89118125#��[  5      $��24(�6?   $��Center=�6M   $��
20,0,20,10q�6h   5      �� 5!   
   -   5         ��Name$ 
Count_good��5!      ���	#FFCDD2CC���	#89118125$ Quantity��5"      $��
20,0,20,10q�6-   $��2��6A   $��Center=�6N    % !MaterialDesignFloatingHintTextBox#��[ 5#      $��24(�6?   �� 5%   
   -   5        $��0��5%       " MaterialDesignRaisedDarkButton#��[ 5&      $	��100��5'      $��40��6   $��26(�6   	 � ToolTip$	 Back to Main Window��5(      $	��Top=�6#   $
��Left=�6;   $��	10,10,0,0q�6V   ���	#FFE05500���	#FFE05500.��6�   _Back5*      �� 5,   
   -   5        $��3��5,      #��[ 5-      $	��150��5.      $��50��6   $��28(�6   $	 Confirm good��5/      $��Center=�6   $��Center=�67   ���	#FF036E03���	#FF036E03.��6�   
_Confirm51      53      54      