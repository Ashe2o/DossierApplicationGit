   M S B A M L   `   `   `  ����   AppAdministrationWPF/    )AppAdministrationWPF.View.AdminVisiteView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $
��1665��$
��1000��$��0q�$
��Left=�$	��Top=�.��� -     �Name$  
LayoutRoot��$
��1650��$
��1000��$��0q�$
��Left=�$	��Top=�
���   � � RowDefinitions �� $��* ��� $��80 �.+��  � ColumnDefinitions �� $��* ��� $��10 ��� $��* ��� $��10 ��� $��2* �.+�� -   $  gridVisiteList��$��0�� �� $��60 ��� $��* � �� $	��580 ��� $��* �.+��� -   $��0��$��0��$��40��$��40��$��
10,0,0,100q�$
��Left=�$��Center=�.���� -    ��Name$ 
flecheHaut���� -   $��0��$��0��$��40��$��40��$��10,0,0,-100q�$
��Left=�$��Center=�.���� -   $ 	flecheBas���� -    ��Name$ listboxVisites��$��1��$	��580��$	��350��$	��350��$
��0,10q�$��Right=�$	��Top=�
������� �� DisplayMemberPath$
 Name��$
��25px(� �� SelectionMode$ Single=����� *	Visites+�� -   $��dock_miniature��$��1��$��1��$	��300��$	��300��$��20q�$��Center=�$��Center=�$��18(�
�������$��	Miniature��.��r� -	   $	��230��$	��230�� r� UnloadedBehavior$ Manual=� r� Source �� *Selected.Thumbnail+� $��2��.+��� -
   $ listboxPanorama��$	��900��$��10q�$	��Top=�$
 Name��$
��25px(�$ Single=����� *Selected.Panoramas+� $��4��.+��� $��5q�$��Center=�$	��Top=�$��Prévisualisation��$��25(�
�������� -   $��dock_main_photo��$	��800��$	��800��$��0q�$��Center=�$��Center=�$��Disabled=�$��Disabled=��� $��Center=�$��Bottom=�	 �� Orientation$	 
Horizontal=�.+��� -   $	��150��$��35��$��10q�#��� ��$��Nouveau panorama���� -   $	��150��$��35��$��10q�#��� ��$��Modifier panorama���� -   $	��150��$��35��$��10q�#��� ��$��Supprimer panorama��� $��2�� �� $	��170 ��� $	��170 ��� $	��170 ��� �� $	��170 ��� $	��170 �
 � 	Resources
  �� 
TargetType �� Property �� Value��%1   '��       �� " ��.���  � ��$ Center=�.+��� -    ��Name$ buttonAddVisite��$��0��$	��150��$��35��$��10,22q�#��� ��$��Nouvelle visite��$y�Visible=��� -   $ buttonModifyVisite��$��1��$	��150��$��35��$��10,22q�#��� ��$��Modifier visite��$y�Visible=��� -   $ buttonDeleteVisite��$��2��$	��150��$��35��$��10,22q�#��� ��$��Supprimer visite��$y�Visible=��� -   $ ButtonImporter��$��4��$	��150��$��35��$��10,22q�#��� ��$��Importer��$y�Visible=��� -   $ ButtonExporter��$��5��$	��150��$��35��$��10,22q�#��� ��$��Exporter��$y�Visible=�