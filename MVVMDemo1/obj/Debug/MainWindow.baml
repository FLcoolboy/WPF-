   M S B A M L   `   `   `  ����D  @MVVMDemo1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVMDemo1	MVVMDemo1  5   	       MVVMDemo1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:MVVMDemo1     5   	     � Title$  
MainWindow��5   	   $	��525��5   	   $	��350��5	   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $
��Save��6   � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$	 tb1��5      $��0��5      $��4q�5      
����  �$��24(�5      ��5      �� *Input1+�� 5      -   5        $	 tb2��5      $��1��5      $��4q�5       
����  �$��24(�5"      ��5#      �� *Input2+�� 5$      -   5        $	 tb3��5$      $��2��5%      $��4q�5&      
����  �$��24(�5(      ��5)      �� *Result+�� 5*      -   5         ��Name$ 	addButton��5*      $��3��5+      $	��120��5,      $��80��5-      $	��Add��5.      
��� �����50      �� *
AddCommand+51      52      53      