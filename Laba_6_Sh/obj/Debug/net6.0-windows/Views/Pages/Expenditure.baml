   M S B A M L   `   `   `  ����D  @Laba_6_Sh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Laba_6_Sh.Views.PagesLaba_6_Sh.Views.Pages  5      '    !Laba_6_Sh.Views.Pages.Expenditure   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Laba_6_Sh.Views.Pages     5        N� Title$  Expenditure��5	       � 	Resources 5      *  $System.Windows.Controls.DataGridCell �� 
TargetType   Cell �� Property �� Value��%�   &	        �� 5   
   "  6   �5      �� 5       �@��TextAlignment$ Center=�6<   �� 5       � ��$ 20(�6-   �� 5       � ��$ Arial)�6/   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6L   ��6   �� *" ExpenditureDataTable.DefaultView+   ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � ��$ Center=�6C   6T   �� 5       � ��$	 5 0q�60   6>   �� 5       � ��$ 20(�61   6>   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   	CellStyle# [  6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 10* 6G   
   Header$
 Id��6S      
IsReadOnly$
 True��6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6_   �� *ID+6v     5       # [  6%   $		 10* 6G   $
 День��6S    6a   �� *DAY+  5!      # [  6%   $		 10* 6G   $
 
Месяц��6S    6b   �� *MONTH+  5"      # [  6%   $		 10* 6G   $
 Год��6S    6`   �� *YEAR+  5#      # [  6%   $		 20* 6G   $
 Категория��6S    6f   �� *
CATEGORY+  5$      # [  6%   $		 15* 6G   $
 
Сумма��6S    6b   �� *MONEY+  5%      # [  6%   $		 20* 6G   $
 Член Семьи��6S    6g   �� *FAMILY_MEMBER_ID+  5&      # [  6%   $		 10* 6G   $
 План��6S    6a   �� *PLAN_MEMBER_ID+5(      5)      5*      