   M S B A M L   `   `   `  ����   AppAdministrationWPF(    "AppAdministrationWPF.View.DiapoAdd   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Ajouter/Modifier Diapo��$	��500��$	��700��.��� .+��� $��	8,8,8,350q�
���   �$��1q�._�r� -    r�Name$ Apercu��$	��300�� r� Stretch$ Uniform=� r� Volume$ 0Q� r� Source �� *Path+� $	��300��$��8,0,8,8q�$��Bottom=� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* � � ColumnDefinitions �� $��1* ��� $��2* ��� $��1* �.+��� -   $��label1��$��0��$��0��$��Right=�$��Center=�$��Chemin :���� -   $��txtPath��$��0��$��1��$��Stretch=�$��Center=����� *Path+�� -   $��cbxType��$��1��$��2��$	��100��$��22��$��Stretch=�.@��� -   $��Photo�� �� 
IsSelected . .��Photo�� -   $��Video��.��Video�� -   $��Panorama��.��
Panorama�� -   $��	lblNameFR��$��1��$��0��$��Right=�$��Center=�$��Titre :��$y�Visible=��� -	   $��lblDescriptionFR��$��2��$��0��$��Right=�$	��Top=�$��Paragraphe FR :��$y�Visible=��� -
   $��	txtNameFR��$��1��$��1��$��Stretch=�$��Center=� �� MaxLines$	 100��$y�Visible=��� -   $��txtDescriptionFR��$��2��$��1��$	��110��$��Stretch=�$��Center=�	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 .  �� 	IsEnabled .  �� TextWrapping$
 Wrap=�$
��Auto=�$y�Visible=��� -   $��lblDescriptionCAT��$��2��$��0��$��Right=�$	��Top=�$��Paragraphe CAT :��$y�Hidden=��� -   $��txtDescriptionCAT��$��2��$��1��$	��110��$��Stretch=�$��Center=�	 . 
 .  . $
 Wrap=�$
��Auto=�$y�Hidden=��� -   $��lblDescriptionEN��$��2��$��0��$��Right=�$	��Top=�$��Paragraphe EN :��$y�Hidden=��� -   $��txtDescriptionEN��$��2��$��1��$	��110��$��Stretch=�$��Center=�	 . 
 .  . $
 Wrap=�$
��Auto=�$y�Hidden=��� -   $��lblDescriptionES��$��2��$��0��$��Right=�$	��Top=�$��Paragraphe ES :��$y�Hidden=��� -   $��txtDescriptionES��$��2��$��1��$	��110��$��Stretch=�$��Center=�	 . 
 .  . $
 Wrap=�$
��Auto=�$y�Hidden=��� -   $��lblDescriptionDE��$��2��$��0��$��Right=�$	��Top=�$��Paragraphe DE :��$y�Hidden=��� -   $��txtDescriptionDE��$��2��$��1��$	��110��$��Stretch=�$��Center=�	 . 
 .  . $
 Wrap=�$
��Auto=�$y�Hidden=��� -   $��lblImg1��$��3��$��0��$��Right=�$	��Top=�$��	Image 1 :���� -   $��lblImg2��$��4��$��0��$��Right=�$	��Top=�$��	Image 2 :���� -   $��SourceMedia��$��5��$��0��$��Right=�$	��Top=�$��©Copyright :���� -   $��txtImg1��$��3��$��1��$��Stretch=�$��Center=�$	 100���� -   $��txtImg2��$��4��$��1��$��Stretch=�$��Center=�$	 100���� -   $��Source��$��5��$��1��$��Stretch=�$��Center=�$	 100���� -   $��LangageType��$��2��$��2��$	��100��$��22��$	��Top=�$��Stretch=�.@��� -   $��FR�� . .��FR�� -   $	��CAT��.��CAT�� -   $��EN��.��EN�� -   $��ES��.��ES�� -   $��DE��.��DE�� -    $��btOpen��$��0��$��2��$	��100��$��20��$��Stretch=�$��Center=�$��Parcourir...���� -!   $��btImg1��$��3��$��2��$	��100��$��20��$��Stretch=�$��Center=�$��Parcourir...���� -"   $��btImg2��$��4��$��2��$	��100��$��20��$��Stretch=�$��Center=�$��Parcourir...���� -#   $��stackPanel1��$��6��$��0��$��3��$��Right=�$	��Top=� �� Orientation$ 
Horizontal=�.+��� -$   $
��btOK��$��60��$��2q�$��OK��$
��Bold"��� -%   $��btCancel��$��60��$��2q�$��Annuler��