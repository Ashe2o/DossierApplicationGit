   M S B A M L   `   `   `  ����   AppAdministrationWPF/    )AppAdministrationWPF.View.AdminPuzzleView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $
��Auto��$
��Auto��$��	10,0,0,10q�.��� -   $��
LayoutRoot��$	��650��$	��340��
���   �.+��� -   $��GroupAdminPuzzle��$��5q�$��Stretch=�$��Stretch=����� $��Configuration des puzzles��$��22(�$
��Bold"�
�������.��� -   $��MainGrid��  � ColumnDefinitions  �� $	��130 ��� $��* � � RowDefinitions �� $
��380* ��� $	��80* �.+��� $��1��$��0��$��Center=�.+��� -   $	��100��$��30��$
��0,10q�$��Import���� -   $	��100��$��30��$
��0,10q�$��Export��� -   $��ListButtons��$��0��$��0�� �� $��* ��� $��* ��� $��* �.+��� -   $��buttonPuzzleEasy��$��0��$	��120��$	��120��$��0q�
������ $��1q�
 � Tag$
 Easy��.����  �� Orientation$ Vertical=�.+��� -    ��Name$ niveau1Puzzle��$	��120��$��64���� $��0,0,0,0q�$��Center=�
�������$��6 pièces - Photo���� $��0,0,0,0q�$��Center=�
�������$��900x600���� -	   $��buttonPuzzleMedium��$��1��$	��120��$	��120��$��0q�
������ $��1q�$ Medium��.���� $ Vertical=�.+��� -
   $ niveau2Puzzle��$	��120��$��64���� $��0,0,0,0q�$��Center=�
��������� $�6 pièces - ����  � Language$ fr-fr�$�Photo ���� $��0,0,0,0q�$��Center=�
�������$��900x600���� -   $��buttonPuzzleHard��$��2��$	��120��$	��120��$��0q�
������ $��1q�$
 Hard��.���� $ Vertical=�.+��� -   $ niveau3Puzzle��$	��120��$��64���� $��0,0,0,0q�$��Center=�
�������$��12 pièces - Photo���� $��0,0,0,0q�$��Center=�
�������$��1200x900���� -   $��
ListPuzzle��$��0��$��1��$��	0,10,10,0q� �� SelectionMode$ Single=����� *
Pictures+ �� SelectedItem �� *
Selected+���� .R�� .+�r� $��1��$��1��$	��200��$	��200�� r� Volume$ 0Q�	 r� Source	 �� *Source+�� $��0��$��1��$��Center=����� *Nom+���� .R�� ���� *ActualWidth+
 �� RelativeSource
 ��  �� AncestorType$ ScrollContentPresenterL�� -    �Name$ 	AreaAdmin��$��1��$��1��$��0,10,0,0q�y��� *BackgroundsVisible+  �� $��* ��� $	��200 �.+��� $��Center=�$��Center=�$��2��$��
1300,0,0,0q�.+��� -   $��	AddButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��Ajouter���� -   $��ModifyButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��Modifier���� -   $��DeleteButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��	Supprimer��� -   $ gridAdministration��$��0��$y�Hidden=�  �� $��75 ��� $��2* ��� $	��100 ��� $��3* � �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��Right=�$��Center=�$��Source:��
��������� -    ��Name$ 	txtSource��$��1��$��23��$	��2,5q�$��Stretch=�$��Center=�{�.  ���� *Selected.Source+ �� Mode$ OneWay=��� -    ��Name$ ButtonBrowse��$��0��$��2��$��60��$��4,0,4,0q�$��Center=�$��Center=�$��	Parcourir��r� -    r�Name$ previewMedia��$��3��$��3��$	��160��$��Stretch=�$	��Top=� r� Stretch$ Uniform=�	 �� *Selected.Source+$ OneWay=��� $��1��$��0��$��Right=�$��Center=�$
��Nom:��
��������� -   $ txtName��$��1��$��1��$��2��$��23��$	��2,5q�$��Stretch=�$��Center=����� *Selected.Name+$ OneWay=��� $��2��$��3��$��Stretch=�$��Bottom=�$��RightToLeft=�$ 
Horizontal=�.+��� -   $��75��$��23��$
��5,10q�$	��Top=�$��Valider���� -   $��75��$��23��$
��5,10q�$	��Top=�$��Annuler��