   M S B A M L   `   `   `  ����@  <posms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:posmsposms  5   	       posms.LoginWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   !localclr-namespace:posms   5   	     � Title$  LoginWindow��5	   	   $	��450��6   $	��800��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � Icon$" Resources/sisense2-copy1.png��6q   ��5
      �� 5   
    �� ImageSource$! Resources/Background1-1.png��6    j� Stretch$
 Fill=�6?   .��5      � .+�5   
   �� -   5         ��Name$
 Name��5      ���	#FFCED2CE)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��5      ���	#89118125.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextBoxViewMargin$ 1 0 1 0q�5      	   FloatingScale$		 0.6Q�5       %  !MaterialDesignFloatingHintTextBox#��[  5      $��24(�5      $	��350��6   $��Center=�5      $��Center=�6(   $��0,0,0,50q�6E   
 �� 
CaretBrush
 �	#FF1C8D26 �� SelectionBrush �	#FF218D396n   G� 5   
   -   5         G�Name$ Password��5      $ Password��5      $		 0.6Q�68   $	��350��6f    G� Password$  ��6r   ���	#FFCED2CE$��24(�6�    ) %MaterialDesignFloatingHintPasswordBox#��[ 5      ���	#89118125$��Center=�5      $��Center=�6(   $��	0,117,0,0q�6E    G� 
CaretBrush �	#FF1C8D26 G� SelectionBrush �	#FF218D395      �� 5   
   -   5         # MaterialDesignRaisedLightButton#��[ 5        � ToolTip$! Log in as a registered user��5!      $��145,330,495,36q�64   $
��Auto��6L   $��24(�6Z   ���	#FF0C7106���	#FF0C7106.��6�   	_Employee5#      �� 5$   
   -   5         " MaterialDesignRaisedDarkButton#��[ 5%      $ Log in as a guest��5&      $��499,330,151,36q�6*   $
��Auto��6B   $
��Auto��6P   $��24(�6]   ���	#FFE05900���	#FFE05900.��6�   _Guest5(      �� 5*   
    # MaterialDesignHeadlineTextBlock#��[ 5+      $��36(�6F   $	��Top=�6T   $��Center=�6l   $��0,40,0,0q�6�   	Sign in5-      5.      5/      