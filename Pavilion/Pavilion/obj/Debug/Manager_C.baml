   M S B A M L   `   `   `  ����C  ?Pavilion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PavilionPavilion  5          Pavilion.Manager_C   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Pavilion     5        N� Title$  	Manager_C��5	      .��5      � -   5         �Name$ Manager_CGrid��5       � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��175* �6   �� 5      $
��175* �6   �� 5      $
��175* �6   �� 5      $
��175* �6    � RowDefinitions 5   
   �� 5      $	��63* �6   �� 5      $
��318* �6   �� 5      $	��60* �6   �� 5      $��8* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridView��5       �� SelectedIndex$ 0��6)   |�.     CanUserReorderColumns .     CanUserAddRows .     CanUserDeleteRows .  	   CanUserResizeRows	 .  
   
IsReadOnly
 . $��5��6�   $��0,63,0,59.6q�6  $��3��6"  ���	#FF3A6F4C63  �� 5   
   -   5         ��Name$ View_SC��5      $��Просмотр ТЦ��6"   $��35��68   $	��140��6D   $��4��6f   �� 5   
   -   5        $ Add_SC��5      $��Добавление ТЦ��6!   $��35��69   $	��140��6E   $��2��6f   �� 5   
   -   5        $ 	Change_SC��5      $��Изменение ТЦ��6$   $��35��6;   $	��140��6G   $��1��6i   $��2��6y   �� 5   
   -   5        $ View_Pavilion��5      $+��%Просмотр Павильонов��6(   $��35��6F   $	��140��6R   $��3��6z   �� 5   
   -   5        $ Add_Pavilion��5      $-��'Добавление Павильона��6'   $��35��6F   $	��140��6R   $��1��6y   �� 5   
   -   5        $ Change_Pavilion��5      $+��%Изменение Павильона��6*   $��35��6H   $	��140��6T   $��2��6u   $��2��6�   �� 5    
   -	   5        $ 	Remove_SC��5       $��Удаление ТЦ��6$   $��35��6:   $	��140��6F   $��3��6h   $��2��6x   �� 5!   
   -
   5        $ Remove_Pavilion��5!      $)��#Удаление Павильона��6*   $��35��6G   $	��140��6S   $��4��6u   $��2��6�   �� 5"   
   -   5         ��Name$ Remove_Field��5"      $
��Left=�6(   $��35��6C   $��
0,12.4,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $��	Поле ��6w   $	��Top=�6�   $��85��6�    �� TextAlignment$ Center=�6�   $��2��6�    J� RenderTransformOrigin$ 0.579,-0.525&�6�   �� 5#   
   -   5        $
 Exit��5#      $��
Выход��6   $��35��6/   $��90��6;   $��0��6Y   5%      5&      