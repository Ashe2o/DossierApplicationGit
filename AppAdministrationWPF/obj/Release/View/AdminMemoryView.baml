   M S B A M L   `   `   `  ����   AppAdministrationWPF/    )AppAdministrationWPF.View.AdminMemoryView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $
��Auto��$
��Auto��$��	10,0,0,10q�  � 	Resources     RedGlowItemContainer �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName��%�   &	        �� " ��.���  � �� �� " ��.R��� $ 
IconBorder��$��1q�._���  P�  �@��
IsSelected . . ��� $	 
IconBorder�� � ��
 �����.��� -   
 �Name$
 
LayoutRoot��$	��650��$	��350��
���   �.+��� -   $��GroupAdminMemory������ $��Memory��$��22(�$
��Bold"�
�������.��� -   $��MainGrid�� � ColumnDefinitions �� $	��130 ��� $��* � � RowDefinitions �� $
��380* ��� $	��80* �.+��� $��1��$��0��$��Center=�.+��� -   $	��100��$��30��$
��0,10q�$��Import���� -   $	��100��$��30��$
��0,10q�$��Export��� -   $��ListButtons��$��0��$��0�� �� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $��	btMemory1��$��0��$��95��$��95��$
��5,10q�$��Stretch=�
������ 
 � Tag$
 Easy��.����  �� Orientation$ Vertical=�.+��� -    ��Name$ niveau1Memory��$��80��$��50���� $��3,0,0,0q�$��Center=�
�������$��
Memory 16p���� -	   $��	btMemory2��$��1��$��95��$��95��$
��5,10q�$��Stretch=�
������ $ Medium��.���� $ Vertical=�.+��� -
   $ niveau2Memory��$��80��$��50���� $��3,0,0,0q�$��Center=�
�������$��
Memory 16p���� -   $��	btMemory3��$��2��$��95��$��95��$
��5,10q�$��Stretch=�
������ $
 Hard��.���� $ Vertical=�.+��� -   $ niveau3Memory��$��80��$��50���� $��3,0,0,0q�$��Center=�
�������$��
Memory 36p���� -   $��btBackground��$��3��$��95��$��95��$��	5,20,5,10q�$��Stretch=�
������ $ 
Background��.���� $ Vertical=�.+��� -   $ arrierePlansMemory��$��80��$��50���� $��3,0,0,0q�$��Center=�
�������$��Arrieres Plans���� -   $��ListPictures��$��0��$��1��$��	0,10,10,0q� �� SelectionMode$ Single=����� *
Pictures+ �� SelectedItem �� *
Selected+���� .R�� ���� *ActualWidth+ �� RelativeSource ��  �� AncestorType" ������ .R��� $	��200��$	��200��$��5q�$ Vertical=�.+��� $��Center=�$��Center=����� *Name+�� $	��170��$��Uniform=����� *Source+� -   $
 bgActionPan��$��1��$��1��$��0,10,0,0q�y��� *BackgroundsVisible+ �� $��* ��� $	��200 �.+��� $��Center=�$��Center=�$��2��$��
1300,0,0,0q�.+��� -   $��	AddButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��Ajouter���� -   $��ModifyButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��Modifier���� -   $��DeleteButton��$y�	Collapsed=�$	��100��$��5q�$��5q�$��	Supprimer��� -   $
 gridAdministration��$��0��$y�Hidden=� �� $��75 ��� $��2* ��� $	��100 ��� $��3* � �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��Right=�$��Center=�$��Source:��
��������� -    ��Name$ 	txtSource��$��1��$��23��$	��2,5q�$��Stretch=�$��Center=�{�.  ���� *Selected.Source+ �� Mode$ OneWay=��� -   $��0��$��2��$��60��$��4,0,4,0q�$��Center=�$��Center=�$��	Parcourir��r� -    r�Name$ previewMedia��$��3��$��3��$	��160��$��Stretch=�$	��Top=� r� Stretch$ Uniform=� r� Source �� *Selected.Source+$ OneWay=��� $��1��$��0��$��Right=�$��Center=�$
��Nom:��
��������� -   $ txtName��$��1��$��1��$��2��$��23��$	��2,5q�$��Stretch=�$��Center=����� *Selected.Name+$ OneWay=��� $��2��$��3��$��Stretch=�$��Bottom=�$��RightToLeft=�$ 
Horizontal=�.+��� -   $��75��$��23��$
��5,10q�$	��Top=�$��Valider���� -   $��75��$��23��$
��5,10q�$	��Top=�$��Annuler��