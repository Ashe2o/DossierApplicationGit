   M S B A M L   `   `   `  ����   AppAdministrationWPF'    !AppAdministrationWPF.View.ExpoAdd   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Ajouter/Modifier Expo��$	��400��$	��550�� � 
ResizeMode$ CanResizeWithGrip=� � ShowInTaskbar .   � Topmost . .��� .+��� $��	8,8,8,220q�
���   �$��1q�._�r� -    r�Name$ Apercu�� r� Stretch$ Uniform=� r� Volume$ 0Q� r� Source �� *Path+� $	��200��$��8,0,8,8q�$��Bottom=� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �	 � ColumnDefinitions	 �� $	��100 ��� $��2* ��� $��1* �.+��� -   $��label1��$��0��$��0��$��Right=�$��Center=�$��Chemin :���� -   $��txtPath��$��0��$��1��$��Stretch=�$��Center=����� *Path+�� -   $��	lblNameFR��$��1��$��0��$��Right=�$��Center=�$��
Titre FR :��$y�Visible=��� -   $��lblDescriptionFR��$��2��$��0��$��Right=�$	��Top=�$��Description FR :��$y�Visible=��� -   $��	txtNameFR��$��1��$��1��$��Stretch=�$��Center=�
 �� MaxLines$	
 100��$y�Visible=��� -   $��DescriptionFR��$��2��$��1��$��60��$��Stretch=�$��Center=� �� AcceptsReturn .  �� 
AcceptsTab .  �� 	IsEnabled .  �� TextWrapping$
 Wrap=�$y�Visible=��� -   $��
lblNameCAT��$��1��$��0��$��Right=�$��Center=�$��Titre CAT :��$y�Hidden=��� -	   $��lblDescriptionCAT��$��2��$��0��$��Right=�$	��Top=�$��Description CAT :��$y�Hidden=��� -
   $��
txtNameCAT��$��1��$��1��$��Stretch=�$��Center=�$	
 100��$y�Hidden=��� -   $��DescriptionCAT��$��2��$��1��$��60��$��Stretch=�$��Center=� .  .  . $
 Wrap=�$y�Hidden=��� -   $��	lblNameEN��$��1��$��0��$��Right=�$��Center=�$��
Titre EN :��$y�Hidden=��� -   $��lblDescriptionEN��$��2��$��0��$��Right=�$	��Top=�$��Description EN :��$y�Hidden=��� -   $��	txtNameEN��$��1��$��1��$��Stretch=�$��Center=�$	
 100��$y�Hidden=��� -   $��DescriptionEN��$��2��$��1��$��60��$��Stretch=�$��Center=� .  .  . $
 Wrap=�$y�Hidden=��� -   $��	lblNameES��$��1��$��0��$��Right=�$��Center=�$��
Titre ES :��$y�Hidden=��� -   $��lblDescriptionES��$��2��$��0��$��Right=�$	��Top=�$��Description ES :��$y�Hidden=��� -   $��	txtNameES��$��1��$��1��$��Stretch=�$��Center=�$	
 100��$y�Hidden=��� -   $��DescriptionES��$��2��$��1��$��60��$��Stretch=�$��Center=� .  .  . $
 Wrap=�$y�Hidden=��� -   $��	lblNameDE��$��1��$��0��$��Right=�$��Center=�$��
Titre DE :��$y�Hidden=��� -   $��lblDescriptionDE��$��2��$��0��$��Right=�$	��Top=�$��Description DE :��$y�Hidden=��� -   $��	txtNameDE��$��1��$��1��$��Stretch=�$��Center=�$	
 100��$y�Hidden=��� -   $��DescriptionDE��$��2��$��1��$��60��$��Stretch=�$��Center=� .  .  . $
 Wrap=�$y�Hidden=��� -   $��LangageType��$��1��$��2��$��80��$��22��$��Stretch=�.@��� -   $��FR�� �� 
IsSelected . .��FR�� -   $	��CAT��.��CAT�� -   $��EN��.��EN�� -   $��ES��.��ES�� -   $��DE��.��DE�� -   $��btOpen��$��2��$��75��$��Stretch=�$��Center=�$��Parcourir...���� -   $��stackPanel1��$��4��$��0��$��3��$��Right=�$	��Top=� �� Orientation$ 
Horizontal=�.+��� -    $
��btOK��$��60��$��2q�$��OK��$
��Bold"��� -!   $��btCancel��$��60��$��2q�$��Annuler��