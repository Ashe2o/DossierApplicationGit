   M S B A M L   `   `   `  ����  AppAdministrationWPF+    %AppAdministrationWPF.View.MediaDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  MediaDialog��5   	   $	��400��6   $	��400��6*    � 
ResizeMode$ CanResizeWithGrip=�66    � ShowInTaskbar .   � Topmost . .��5      � .+�5   
   �� 
���   �$��1q�6%   $��	8,8,8,102q�69   ._�5      r� -   5         r�Name$ Apercu��5       r� Volume$ 0Q�6+    r� Stretch$ Uniform=�66    r� Source 6H   �� *Path+5      � 5	   
   $��90��6   $��Bottom=�6   $��8,0,8,8q�66    � RowDefinitions 5
      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    	 � ColumnDefinitions	 5      �� 5      $��1* �6#   �� 5      $��2* �6#   �� 5      $��1* �6#   .+�5      �� -   5        $��label1��5   _   $��0��6   $��0��6!   $��Chemin:��61   $��Right=�6C   $��Center=�6m   �� 5      -   5        $��lblName��5   \   $��1��6   $��0��6!   $
��Nom:��61   $��Right=�6@   $��Center=�6k   �� 5      -   5        $��txtPath��5   Q   $��0��6   $��1��6#   $��Stretch=�63   $��Center=�6`   ��6{   �� *Path+�� 5      -   5        $��txtName��5   Q   $��1��6   $��1��6#   $��Stretch=�63   $��Center=�6`   
 �� MaxLines$	
 100��6�   ��6{   �� *Name+6�   �� 5      -   5        $��btOpen��5   b   $��Parcourir...��6   $��2��6,   $��75��6<   $
��Left=�6G   $��Center=�6p   $��5 0 0 0q�6�   �� 5      -   5        $��stackPanel1��5   f   $��0��6   $��3��6)   $��3��6=   $��Right=�6J   $	��Top=�6y    �� Orientation$ 
Horizontal=�6�   .+�5      �� -   5        $
��btOK��5   +   $��OK��6   $��60��6;   $��2q�6F   $
��Bold"�6Q   6c   �� 5      -	   5        $��btCancel��5   +   $��Annuler��6   $��60��6;   $��2q�6F   $y�Hidden=�6h   5      5       5!      5"      