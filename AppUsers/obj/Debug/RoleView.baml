   M S B A M L   `   `   `  ����C  ?AppUsers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AppUsersAppUsers  5          AppUsers.RoleView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:AppUsers     5        � Title$  RoleView��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGridRoles��5         AutoGenerateColumns .     
IsReadOnly . $��1��6U      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6U     5      $ Role id��6%   $ * 6Q    66   �� *RoleId+6]     5      $
 Name��6%   $ * 6L    63   �� *Name+6X     5      $
 Pesa��6%   $ * 6L    63   �� *Pesa+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)      CellTemplate 5      �� 5      .R�5      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5   "   �� $
��50px��6)   .��66   Delete6>   5      5      5      5       �� 5!   
   -   5        
 ��Name$
 ExitBtn��5!   W   $
��Exit��6   $��486,392,114,10q�6    $��200px��68   
���  ��6�   �� 5"   
   -   5        $
 AddBtn��5"   E   $	��Add��6   $��117,392,483,10q�6   $��200px��67   6l   5#      5$      