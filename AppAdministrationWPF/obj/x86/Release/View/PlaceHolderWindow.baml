   M S B A M L   `   `   `  ����   AppAdministrationWPF1    +AppAdministrationWPF.View.PlaceHolderWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Modifier PlaceHolders��$	��600��$	��800�� � 
ResizeMode$ 	CanResize=� � ShowInTaskbar .   � Topmost . .��� -   $
��grid�� � RowDefinitions �� $
��Auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto � � ColumnDefinitions �� $
��Auto ��� $��* �.+��� -   $��label1��$��0��$��0��$
��auto��$��Right=�$��Nom :���� -   $��label4��$��3��$��0��$
��auto��$��Right=�$	��top=�$��	Media(s):���� -   $��label2��$��1��$��0��$��Right=�$	��Top=�$��Icone :���� -   $��txtName��$��0��$��1��$
��10,5q�$��Stretch=�����  �� Path$ Selected.Name��� $��1��$��1��$��10q� �� Orientation$ 
Horizontal=�.+��� $��1��$��1��$��75��$��75��
�������$��1q�._��� $��1��$��1������ *Selected.IconPath+�� -   $��txtIconPath��$��25��$
��10,5q�$��Stretch=�$��Bottom=�$��Parcourir ...���� -   $��	labelOpen��$��1��$��0��$
��10,5q�$��Stretch=�$��Icône Ouverte:���� $��1��$��2��$��75��$��75��
�������$��1q�._��� $��1��$��1������ *Selected.IconPathOpen+�� -   $��txtIconPathOpen��$��25��$
��10,5q�$��Stretch=�$��Bottom=�$��Parcourir ...��� $��4�� �� $
��Auto ��� $
��auto ��� $
��auto �.+��� -	   $��
btAddMedia��$��0��$��0��$
��10,5q�$��Stretch=�$	��Top=�$��
Ajouter...�� � ToolTip$ Ajouter un media���� -
   $��btModifyMedia��$��1��$��0��$
��10,5q�$��Stretch=�$	��Top=�$��Modifier...��$ Modifier un media���� -   $��btDeleteMedia��$��2��$��0��$
��10,5q�$��Stretch=�$	��Top=�$��	Supprimer��$ Supprimer un media���� -   $��lbMedia��$��4��$��2��$��1��$��10,10,10,50q�$��Stretch=����� $ Selected.Media����� .R��� $	��170��$��5,5,5,5q�
�������$��1q�	 �� CornerRadius$	 2��._��� $��5,5,5,5q�$ 
Horizontal=�.+��� $��90��$��90��$��5,5,5,5q�
���   �
���   �$��1q�._�r� 
 r�Name$
 Apercu�� r� Stretch$ Uniform=� r� Volume$ 0Q� r� Source �� *Path+�� $��Center=����� *Name+ � ContextMenu �� $��cm��.@�m� $��miEditPH��-   $��Modifier��m� $��
miDeletePH��-   $��	Supprimer���� $��5��$��2��$��8,8,8,8q�$��Right=�$��Bottom=�$ 
Horizontal=�.+��� -   $
��btOk��$��60��$��2q�$��OK��$
��Bold"��� -   $��btCancel��$��60��$��2q�$��Annuler��